using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Katas
{
    public class By4Skyscrapers
    {
        public static void Main(string[] args)
        {
            var test1 = new HashSet<int> {1, 2, 3};
            var test2 = new HashSet<int> {4};
            var test3 = new HashSet<int> {1, 2, 3};
            var test4 = new HashSet<int> {5, 6};
            List<HashSet<int>> listTests = new List<HashSet<int>> {test1, test2, test3, test4};


            var testSet = listTests
                .Where(s => s.Count != 1)
                .SelectMany(n => n)
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .ToHashSet();


            var test = listTests
                .Where(s => s.Count != 1)
                .SelectMany(n => n)
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .ToHashSet();

            foreach (var one in test)
            {
                Console.WriteLine(one.Key);
            }

            // var unique = new HashSet<int>();
            //
            // foreach (var test in listTests)
            // {
            //     HashSet<int> temp = new HashSet<int>();
            //
            // }


            var answer = new HashSet<int>();


            // test.UnionWith(Enumerable.Range(1, 3));

            //todo                           v           v           v           v
            // int[] cluesForTest = {1, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //todo  <--- good
            int[] cluesForTest = {0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0}; //todo  <--- good
            //todo                                 v                 v                 v                v
            // int[] cluesForTest = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6};
            SolvePuzzle(cluesForTest);




        }

        public static String dupa(string name)
        {
            return (name.ToLower()[0] == 'r')?name + " plays banjo": name + " does not play banjo";
        }

        // const int Max = 4, Max = 4, MAXNUMBERS = 4;
        // static int countGood = 0;
        // static int[] upClues;
        // static int[] bottomClues;
        // static int[] leftClues;
        // static int[] rightClues;
        // static int[][][] board;

        public static int[][] SolvePuzzle(int[] clues)
        {
            const int Max = 4;
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            var board = new HashSet<int>[Max][];

            SetClues(clues, out upClues, out rightClues, out bottomClues, out leftClues);
            MakeEmptyBoard(board, Max);
            // SetUpEdge(board, upClues, Max);
            SetUpEdge2(board, upClues, Max);
            // SetRightEdge(board, rightClues, upClues, Max);
            SetRightEdge2(board, rightClues, Max);
            // SetBottomEdge(board, bottomClues, rightClues, Max);
            SetBottomEdge2(board, bottomClues, Max);
            // SetLeftEdge(board, leftClues, bottomClues, upClues, Max);
            SetLeftEdge2(board, leftClues, Max);
            FillEmptySpaces(board, Max);
            // todo RemoveImpossibleFromEdgesToInside(board, upClues, rightClues, bottomClues, leftClues, Max);

            while (board.SelectMany(s => s).Any(s => s.Count == 1))
            {
                FindAllReadyFieldAndRemoveFromRowAndColumn(board, Max); //todo have to be second 1
                // FindMaxAndEdgeAndRemoveImpossibleFromMax(board, upClues, rightClues, bottomClues, leftClues, Max);
                FindSingleInRowOrColumnAndSet(board, Max); //todo have to be second 2 <--- have to be LAST !!! ..!5.. 6 (1,4,5) 3 (4,2,1) <--- 2

                Console.WriteLine("test");
            }

            Console.WriteLine(board[0]);


            return new int[1][];
        }

        private static void SetUpEdge2(IReadOnlyList<HashSet<int>[]> board, IReadOnlyList<int> upClues, int Max)
        {
            for (var x = 0; x < Max; x++)
            {
                if (upClues[x] == 1)
                {
                    board[0][x].Clear();
                    board[0][x].Add(Max);
                }
                else if (upClues[x] == Max)
                {
                    for (var y = 0; y < Max; y++)
                    {
                        // if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(y + 1);
                    }

                }
                else if (upClues[x] != 0)
                {
                    for (int y = 0, i = 0; y < Max; y++, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Count == 0 ||
                             board[y][x].Count > Enumerable.Range(1, Max - upClues[x] + 1).Count())
                            )
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - upClues[x] + 1));
                        }
                        else if(Max - upClues[x] + 1 + i < Max &&
                                (board[y][x].Count == 0 ||
                                 board[y][x].Count > Enumerable.Range(1, Max - upClues[x] + 1 + i).Count()))
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - upClues[x] + 1 + i));
                        }
                    }
                }
            }
        }

        private static void SetRightEdge2(
            HashSet<int>[][] board,
            IReadOnlyList<int> rightClues,
            int Max)
        {
            for (var y = 0; y < rightClues.Count; y++)
            {
                if (rightClues[y] == 1)
                {
                    board[y][Max - 1].Clear();
                    board[y][Max - 1].Add(Max);
                }
                else if (rightClues[y] == Max)
                    for (var x = Max - 1; x >= 0; x--)
                    {
                        // if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(Max - x);
                    }
                else if (rightClues[y] != 0)
                {
                    for (int x = Max - 1, i = 0; x >= 0; x--, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Count == 0 ||
                             board[y][x].Count > Enumerable.Range(1, Max - rightClues[y] + 1).Count())
                        )
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - rightClues[y] + 1));
                        }
                        else if(Max - rightClues[y] + 1 + i < Max &&
                                (board[y][x].Count == 0 ||
                                 board[y][x].Count > Enumerable.Range(1, Max - rightClues[y] + 1 + i).Count()))
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - rightClues[y] + 1 + i));
                        }
                    }
                }
            }
        }

        private static void SetBottomEdge2(
            HashSet<int>[][] board,
            IReadOnlyList<int> bottomClues,
            int Max)
        {
            for (var x = Max - 1; x >= 0; x--)
            {
                if (bottomClues[x] == 1)
                {
                    board[Max - 1][x].Clear();
                    board[Max - 1][x].Add(Max);
                }
                else if (bottomClues[x] == Max)
                    for (var y = Max - 1; y >= 0; y--)
                    {
                        // if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(Max - y);
                    }
                else if (bottomClues[x] != 0)
                {
                    for (int y = Max - 1, i = 0; y >= 0; y--, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Count == 0 ||
                             board[y][x].Count > Enumerable.Range(1, Max - bottomClues[x] + 1).Count())
                        )
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1));
                        }
                        else if(Max - bottomClues[x] + 1 + i < Max &&
                                (board[y][x].Count == 0 ||
                                 board[y][x].Count > Enumerable.Range(1, Max - bottomClues[x] + 1 + i).Count()))
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1 + i));
                        }
                    }
                }
            }
        }

        private static void SetLeftEdge2(
            HashSet<int>[][] board,
            IReadOnlyList<int> leftClues,
            int Max)
        {
            for (var y = 0; y < leftClues.Count; y++)
            {
                if (leftClues[y] == 1)
                {
                    board[y][0].Clear();
                    board[y][0].Add(Max);
                }
                else if (leftClues[y] == Max)
                    for (var x = 0; x < Max; x++)
                    {
                        // if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(x + 1);
                    }
                else if (leftClues[y] != 0)
                {
                    for (int x = 0, i = 0; x < Max - 1; x++, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Count == 0 ||
                             board[y][x].Count > Enumerable.Range(1, Max - leftClues[y] + 1).Count())
                        )
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                        }
                        else if(Max - leftClues[y] + 1 + i < Max &&
                                (board[y][x].Count == 0 ||
                                 board[y][x].Count > Enumerable.Range(1, Max - leftClues[y] + 1 + i).Count()))
                        {
                            board[y][x].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1 + i));
                        }
                    }
                }
            }
        }

        private static bool FindMaxAndEdgeAndRemoveImpossibleNextToMax(
            IReadOnlyList<HashSet<int>[]> board,
            IReadOnlyList<int> upClues,
            IReadOnlyList<int> rightClues,
            IReadOnlyList<int> bottomClues,
            IReadOnlyList<int> leftClues, int Max)
        {
            var change = false;
            for (var y = 0; y < Max; y++)
            {
                //todo if contains MAX then:
                //todo     only row or column depend on edges and pass edges too
                if (!board[y].Any(s => s.Contains(Max))) continue;
                if (upClues[y] == 0 && bottomClues[y] == 0 && leftClues[y] == 0 && rightClues[y] == 0) continue;
                change = FindMaxAndEdgeAndRemoveImpossibleNextToMaxLogic(board, upClues, bottomClues, leftClues,
                             rightClues, Max) || change;
            }

            return change;
        }

        private static bool FindMaxAndEdgeAndRemoveImpossibleNextToMaxLogic(
            IReadOnlyList<HashSet<int>[]> board,
            IReadOnlyList<int> upClues,
            IReadOnlyList<int> bottomClues,
            IReadOnlyList<int> leftClues,
            IReadOnlyList<int> rightClues,
            int Max)
        {
            var change = false;
            for (var i = 0; i < Max - 2; i++)
            {
                for (var y = 0; y < Max; y++)
                {
                    for (var x = 0; x < Max; x++)
                    {
                        if (board[y][x].Count != 1 || !board[y][x].Contains(Max - i)) continue;
                        if (upClues[x] != 0 && y > 1)
                        {
                            // if(board[y - 1][x].Contains(Max - i))
                        }

                        if (bottomClues[x] != 0 && y < Max - 2)
                        {
                        }

                        if (leftClues[y] != 0 && x > 1)
                        {
                        }

                        if (rightClues[y] != 0 && x < Max - 2)
                        {
                        }
                    }
                }
            }

            throw new NotImplementedException();
        }


        private static void FindAllReadyFieldAndRemoveFromRowAndColumn(IReadOnlyList<HashSet<int>[]> board, int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                var single = board[y].Where(s => s.Count == 1).ElementAtOrDefault(0)?.ElementAtOrDefault(0);
                if (single == 0) continue;
                RemoveImpossible(board[y], single);
                var columns = new List<HashSet<int>>();
                for (var x = 0; x < Max; x++)
                {
                    columns.Add(board[y][x]);
                }

                RemoveImpossible(columns.ToArray(), single);
            }
        }

        private static void RemoveImpossible(IEnumerable<HashSet<int>> rowOrColumn, int? single)
        {
            foreach (var set in rowOrColumn)
            {
                if (set.Count > 1 && single != null)
                    set.Remove(single.Value);
            }

            // rowOrColumn
            //         .Where(s => s.Count > 1)
            //         .Select(s =>
            //         {
            //             s.Remove((int) single);
            //             return s; //todo remove ?
            //         });
        }

        private static bool FindSingleInRowOrColumnAndSet(IReadOnlyList<HashSet<int>[]> board, int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                if (FindAloneInSetsAndRemoveLogic(board[y])) return true;
            }

            for (var x = 0; x < Max; x++)
            {
                var allSets = new List<HashSet<int>>();
                for (var y = 0; y < Max; y++)
                {
                    allSets.Add(board[y][x]);
                }

                if (FindAloneInSetsAndRemoveLogic(allSets.ToArray())) return true;
            }

            return false;
        }

        private static bool FindAloneInSetsAndRemoveLogic(HashSet<int>[] allSets) //todo bug !!!
        {
            var single = allSets //todo changed to single from singles !!!
                .Where(s => s.Count != 1)
                .SelectMany(n => n)
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .SelectMany(s => s)
                .FirstOrDefault();
            if (single == 0) return false;
            if (allSets.Any(s => s.Count == 1 && s.Contains(single))) return false;
            foreach (var set in allSets)
            {
                if (set.Count == 1 || !set.Contains(single)) continue;
                set.Clear();
                // foreach (var single in singles)
                // {
                set.Add(single);
                // }
                return true;
            }

            return false;
        }

        private static void FillEmptySpaces(
            HashSet<int>[][] board,
            int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                for (var x = 0; x < Max; x++)
                {
                    if (board[y][x].Count != 0) continue;
                    board[y][x] = ReturnOthersCross(board, y, x, Max);
                }
            }
        }

        private static HashSet<int> ReturnOthersCross(HashSet<int>[][] board, int y, int x, int Max)
        {
            HashSet<int> answer = new HashSet<int>();
            answer.UnionWith(Enumerable.Range(1, Max));
            for (var xTemp = 0; xTemp < Max; xTemp++)
            {
                if (board[y][xTemp].Count == 1) answer.Remove(board[y][xTemp].First());
            }

            for (var yTemp = 0; yTemp < Max; yTemp++)
            {
                if (board[yTemp][x].Count == 1) answer.Remove(board[yTemp][x].First());
            }

            return answer;
        }


        private static void SetUpEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> upClues,
            int Max)
        {
            for (var x = 0; x < upClues.Count; x++)
            {
                if (upClues[x] == 1)
                {
                    board[0][x].Add(Max);
                }
                else if (upClues[x] == Max)
                    for (var y = 0; y < Max; y++)
                    {
                        board[y][x].Add(y + 1);
                    }
                else if (upClues[x] != 0) board[0][x].UnionWith(Enumerable.Range(1, Max - upClues[x] + 1));
            }
        }

        private static void SetRightEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> rightClues,
            IReadOnlyList<int> upClues,
            int Max)
        {
            for (var y = 0; y < rightClues.Count; y++)
            {
                if (rightClues[y] == 1)
                {
                    if (board[y][Max - 1].Count == 0)
                    {
                        board[y][Max - 1].Add(Max);
                    }
                    else
                    {
                        board[y][Max - 1].Clear();
                        board[y][Max - 1].Add(Max);
                    }
                }
                else if (rightClues[y] == Max)
                    for (var x = Max - 1; x >= 0; x--)
                    {
                        if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(Max - x);
                    }
                else if (rightClues[y] != 0)
                {
                    if (y == 0)
                    {
                        if (board[y][Max - 1].Count == 1) continue;
                        if (rightClues[y] <= upClues[Max - 1]) continue;
                        board[y][Max - 1].Clear();
                        board[y][Max - 1].UnionWith(Enumerable.Range(1, Max - rightClues[y] + 1));
                    }
                    else
                    {
                        if (board[y][Max - 1].Count == 1) continue;
                        board[y][Max - 1].Clear();
                        board[y][Max - 1].UnionWith(Enumerable.Range(1, Max - rightClues[y] + 1));
                    }
                }
            }
        }

        private static void SetBottomEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> bottomClues,
            IReadOnlyList<int> rightClues,
            int Max)
        {
            for (var x = bottomClues.Count - 1; x >= 0; x--)
            {
                if (bottomClues[x] == 1)
                {
                    if (board[Max - 1][x].Count == 0)
                    {
                        board[Max - 1][x].Add(Max);
                    }
                    else
                    {
                        board[Max - 1][x].Clear();
                        board[Max - 1][x].Add(Max);
                    }
                }
                else if (bottomClues[x] == Max)
                    for (var y = Max - 1; y >= 0; y--)
                    {
                        if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(Max - y);
                    }
                else if (bottomClues[x] != 0)
                {
                    if (x == board[Max - 1].Length - 1)
                    {
                        if (board[Max - 1][x].Count == 1) continue;
                        if (bottomClues[x] <= rightClues[Max - 1]) continue;
                        board[Max - 1][x].Clear();
                        board[Max - 1][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1));
                    }
                    else
                    {
                        if (board[Max - 1][x].Count == 1) continue;
                        board[Max - 1][x].Clear();
                        board[Max - 1][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1));
                    }
                }
            }
        }

        private static void SetLeftEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> leftClues,
            IReadOnlyList<int> bottomClues,
            IReadOnlyList<int> upClues,
            int Max)
        {
            for (var y = 0; y < leftClues.Count; y++)
            {
                if (leftClues[y] == 1)
                {
                    if (board[y][0].Count == 0)
                    {
                        board[y][0].Add(Max);
                    }
                    else
                    {
                        board[y][0].Clear();
                        board[y][0].Add(Max);
                    }
                }
                else if (leftClues[y] == Max)
                    for (var x = 0; x < Max; x++)
                    {
                        if (board[y][x].Count == 1) continue;
                        board[y][x].Clear();
                        board[y][x].Add(Max - x);
                    }
                else if (leftClues[y] != 0)
                {
                    if (y == board.Length - 1)
                    {
                        if (board[y][0].Count == 1) continue;
                        if (leftClues[y] <= bottomClues[0]) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                    else if (y == 0)
                    {
                        if (board[y][0].Count == 1) continue;
                        if (leftClues[y] <= upClues[0]) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                    else
                    {
                        if (board[y][0].Count == 1) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                }
            }
        }

        private static void MakeEmptyBoard(IList<HashSet<int>[]> board, int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                board[y] = new HashSet<int>[Max];
                for (var x = 0; x < Max; x++)
                {
                    board[y][x] = new HashSet<int>();
                }
            }
        }

        private static void SetClues(
            IReadOnlyCollection<int> clues,
            out int[] upClues,
            out int[] rightClues,
            out int[] bottomClues,
            out int[] leftClues)
        {
            var quarter = clues.Count / 4;
            upClues = clues.Take(quarter).ToArray();
            rightClues = clues.Skip(quarter).Take(quarter).ToArray();
            bottomClues = clues.Skip(quarter * 2).Take(quarter).Reverse().ToArray();
            leftClues = clues.Skip(quarter * 3).Take(quarter).Reverse().ToArray();
        }


        //
        //     // tod o    find edge 1 or 4 and fill
        //     // tod o    mark rest of the edge, start from biger       on corner set lover list of numbers???
        //     // tod o    mark rest and set if 1
        //     // tod o    check if one left and set
        //     // todo    while(solve)
        //     // tod o        check if max skyScraper can be placed and put it
        //     // tod o        check if one left and set
        //     // tod o        check if sets excluded 12 and 12 and 123 than there where is 123 set 3
        //     // todo        if necessary than set example 1 -> 4 (1,2,3)(1,2)(1,2,3) <- 2 than 4 (..)(..) 3
        //     // todo        if necessary than set example 3 -> (12)(12) 3 4 <- 1 than 2 1 3 4
        //     // todo        remove impossible from temp sets  1 -> 4 (123) (123) (12) <- 3  than 4 (123) (13) (12)
        //     // todo                             next inter   1 -> 4 (123) (13) (12)  <- 3 than
        //
        //
        //     // todo        check if there are for example row with edge 2 -> (12)(12) 4 3 <- 2 then resolve 2 1 4 3
        //     // tod o        mark rest and if only one then set
        //
        //
        //     // tod o        check and if yes set resolve numbers <---
        //     // tod o        check and if yes set excluded
        //
        //
        //
        //
        //
        //
        // public static void RotateRight(IList sequence, int count)
        // {
        //     object tmp = sequence[count-1];
        //     sequence.RemoveAt(count - 1);
        //     sequence.Insert(0, tmp);
        // }
        //
        // public static IEnumerable<IList> Permutate(IList sequence, int count)
        // {
        //     if (count == 1) yield return sequence;
        //     else
        //     {
        //         for (int i = 0; i < count; i++)
        //         {
        //             foreach (var perm in Permutate(sequence, count - 1))
        //                 yield return perm;
        //             RotateRight(sequence, count);
        //         }
        //     }
        // }
    }
}



 // //todo ------------------------------------
 //
 //            SetClues(clues, out upClues, out rightClues, out bottomClues, out leftClues);
 //            MakeEmptyBoard(board, Max);
 //
 //            var smallerBoard = board;
 //            var smallerUpClues = upClues;
 //            var smallerRightClues = rightClues;
 //            var smallerBottomClues = bottomClues;
 //            var smallerLeftClues = leftClues;
 //            var smallerClues = new[] {smallerUpClues, smallerRightClues, smallerBottomClues, smallerLeftClues};
 //            var i = 0;
 //            while (i < Max / 2)
 //            {
 //                SetUpEdge(smallerBoard, smallerUpClues, Max - (i * 2));
 //                SetRightEdge(smallerBoard, smallerRightClues, smallerUpClues, Max - (i * 2));
 //                SetBottomEdge(smallerBoard, smallerBottomClues, smallerRightClues, Max - (i * 2));
 //                SetLeftEdge(smallerBoard, smallerLeftClues, smallerBottomClues, smallerUpClues, Max - (i * 2));
 //                smallerBoard = new HashSet<int>[Max - (++i * 2)][];
 //                MakeEmptyBoard(smallerBoard, Max - (i * 2));
 //                for (var y = i; y < Max - i; y++)
 //                {
 //                    for (var x = i; x < Max - i; x++)
 //                    {
 //                        smallerBoard[y - i][x - i] = board[y][x];
 //                    }
 //                }
 //
 //                smallerUpClues = new int[Max - (i * 2)];
 //                smallerRightClues = new int[Max - (i * 2)];
 //                smallerBottomClues = new int[Max - (i * 2)];
 //                smallerLeftClues = new int[Max - (i * 2)];
 //                Array.Copy(upClues, i, smallerUpClues, 0, Max - (i * 2));
 //                Array.Copy(rightClues, i, smallerRightClues, 0, Max - (i * 2));
 //                Array.Copy(bottomClues, i, smallerBottomClues, 0, Max - (i * 2));
 //                Array.Copy(leftClues, i, smallerLeftClues, 0, Max - (i * 2));
 //                // smallerUpClues = smallerUpClues.Select(c => (c == 1 || c == (Max - ((i + 1) * 2))) ? 0 : c).Select(c => c - 1).ToArray();
 //                smallerUpClues = smallerUpClues.Select(c => c - 1).Select(c => (c == 1 || c > (Max - (i * 2))) ? 0 : c).ToArray();
 //                smallerRightClues = smallerRightClues.Where(c => c != 1 && c != (Max - ((i + 1) * 2))).Select(i => i - 1).ToArray();
 //                smallerBottomClues = smallerBottomClues.Where(c => c != 1 && c != (Max - ((i + 1) * 2))).Select(i => i - 1).ToArray();
 //                smallerLeftClues = smallerLeftClues.Where(c => c != 1 && c != (Max - ((i + 1) * 2))).Select(i => i - 1).ToArray();
 //            }
 //
 //
 //
 //
 //
 //            FillEmptySpaces(board, Max);
 //
 //            //todo ------------------------------------