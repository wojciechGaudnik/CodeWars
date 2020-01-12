using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class By4Skyscrapers
    {
        public static void Main(string[] args)
        {
            //todo                             v           v           v           v
            int[] cluesForTest =    {0, 0, 0, 0, 0, 0, 0, 0, 4, 4, 4, 4, 0, 0, 0, 0};
            // int[] cluesForTest = {0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0};  //todo  <--- good
            // SolvePuzzle(cluesForTest);


            var  test1 = new HashSet<int>{1,2};
            var  test2 = new HashSet<int>{3, 4};
            var  test3 = new HashSet<int>{1,2};
            var  test4 = new HashSet<int>{1,2,3,4};
            List<HashSet<int>> listTests = new List<HashSet<int>>{test1, test2, test3, test4};
            var test = listTests
                .Where(s => s.Count != 1)
                .SelectMany(n => n)
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .ToHashSet();



            // var unique = new HashSet<int>();
            //
            // foreach (var test in listTests)
            // {
            //     HashSet<int> temp = new HashSet<int>();
            //
            // }
        





            var answer = new HashSet<int>();




            // test.UnionWith(Enumerable.Range(1, 3));

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
            var countGood = 0;
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            var board = new HashSet<int>[Max][];

            SetClues(clues, out upClues, out rightClues, out bottomClues, out leftClues);
            MakeEmptyBoard(board, Max);
            SetUpEdge(board, upClues, ref countGood, Max);
            SetRightEdge(board, rightClues, ref countGood, upClues, Max);
            SetBottomEdge(board, bottomClues, ref countGood, rightClues, Max);
            SetLeftEdge(board, leftClues, ref countGood, bottomClues, upClues, Max);
            SetEmptySpaces(board, ref countGood, Max);
            var numberOfFields = Math.Pow(Max, 2);
            // while (countGood != numberOfFields)
            // {
            //     Remove
            // }
            Console.WriteLine(board[0]);









            return new int[1][];


        }

        private static void SetEmptySpaces(
            HashSet<int>[][] board,
            ref int countGood,
            int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                for (var x = 0; x < Max; x++)
                {
                    if (board[y][x].Count != 0) continue;
                    board[y][x] = ReturnOthersCross(board, y, x, Max);
                    if (board[y][x].Count == 1) countGood++;
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


        private static void SetLeftEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> leftClues,
            ref int countGood,
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
                        countGood++;
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
                        countGood++;
                    }
                else if (leftClues[y] != 0)
                {
                    if (y == board.Length - 1)
                    {
                        if(board[y][0].Count == 1) continue;
                        if(leftClues[y] <= bottomClues[0]) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                    else if (y == 0)
                    {
                        if(board[y][0].Count == 1) continue;
                        if(leftClues[y] <= upClues[0]) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                    else
                    {
                        if(board[y][0].Count == 1) continue;
                        board[y][0].Clear();
                        board[y][0].UnionWith(Enumerable.Range(1, Max - leftClues[y] + 1));
                    }
                }
            }
        }

        private static void SetBottomEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> bottomClues,
            ref int countGood,
            IReadOnlyList<int> rightClues,
            int Max)
        {
            for (var x = bottomClues.Count - 1; x >= 0; x--)
            {
                if (bottomClues[x] == 1)
                {
                    if (board[Max - 1][x].Count == 0)
                    {
                        countGood++;
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
                        countGood++;
                    }
                else if (bottomClues[x] != 0)
                {
                    if (x == board[Max - 1].Length - 1)
                    {
                        if(board[Max - 1][x].Count == 1) continue;
                        if(bottomClues[x] <= rightClues[Max - 1]) continue;
                        board[Max - 1][x].Clear();
                        board[Max - 1][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1));
                    }
                    else
                    {
                        if(board[Max - 1][x].Count == 1) continue;
                        board[Max - 1][x].Clear();
                        board[Max - 1][x].UnionWith(Enumerable.Range(1, Max - bottomClues[x] + 1));
                    }
                }
            }
        }

        private static void SetRightEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> rightClues,
            ref int countGood,
            IReadOnlyList<int> upClues,
            int Max)
        {
            for (var y = 0; y < rightClues.Count; y++)
            {
                if (rightClues[y] == 1)
                {
                    if (board[y][Max - 1].Count == 0)
                    {
                        countGood++;
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
                        countGood++;
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

        private static void SetUpEdge(
            HashSet<int>[][] board,
            IReadOnlyList<int> upClues,
            ref int countGood,
            int Max)
        {
            for (var x = 0; x < upClues.Count; x++)
            {
                if (upClues[x] == 1)
                {
                    countGood++;
                    board[0][x].Add(Max);
                }
                else if (upClues[x] == Max)
                    for (var y = 0; y < Max; y++)
                    {
                        countGood++;
                        board[y][x].Add(y + 1);
                    }
                else if (upClues[x] != 0) board[0][x].UnionWith(Enumerable.Range(1, Max - upClues[x] + 1));
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
            out  int[] rightClues,
            out  int[] bottomClues,
            out  int[] leftClues)
        {
            var quarter = clues.Count / 4;
            upClues = clues.Take(quarter).ToArray();
            rightClues = clues.Skip(quarter).Take(quarter).ToArray();
            bottomClues = clues.Skip(quarter * 2).Take(quarter).Reverse().ToArray();
            leftClues = clues.Skip(quarter * 3).Take(quarter).Reverse().ToArray();
        }





        //
        //     // todo    find edge 1 or 4 and fill
        //     // todo    mark rest of the edge, start from biger       on corner set lover list of numbers???
        //     // todo    mark rest and set if 1
        //     // todo    check if one left and set
        //     // todo    while(solve)
        //     // todo        check if max skyScraper can be placed and put it
        //     // todo        check if one left and set
        //     // todo        check if sets excluded 12 and 12 and 123 than there where is 123 set 3
        //     // todo        if necessary than set example 1 -> 4 (1,2,3)(1,2)(1,2,3) <- 2 than 4 (..)(..) 3
        //     // todo        if necessary than set example 3 -> (12)(12) 3 4 <- 1 than 2 1 3 4
        //     // todo        remove impossible from temp sets  1 -> 4 (123) (123) (12) <- 3  than 4 (123) (13) (12)
        //     // todo                             next inter   1 -> 4 (123) (13) (12)  <- 3 than
        //
        //
        //     // todo        check if there are for example row with edge 2 -> (12)(12) 4 3 <- 2 then resolve 2 1 4 3
        //     // todo        mark rest and if only one then set
        //
        //
        //     // todo        check and if yes set resolve numbers <---
        //     // todo        check and if yes set excluded
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