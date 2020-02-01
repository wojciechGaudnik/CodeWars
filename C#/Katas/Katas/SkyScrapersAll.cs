using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class SkyScrapersAll
    {
        public static void Main(string[] args)
        {
            //todo check string or StringBuilder faster  ?

            // int[] cluesForTest = {0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0}; //todo  <--- good
            // int[] cluesForTest = {0, 2, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 2}; //todo  <--- good
            // int[] cluesForTest = {0, 3, 0, 0, 0, 1, 0, 0, 0, 0, 1, 2, 0, 2, 0, 0}; //todo  <--- good
            // int[] cluesForTest = {0, 1, 0, 0, 0, 0, 1, 2, 0, 2, 0, 0, 0, 3, 0, 0}; //todo  <--- good
            // int[] cluesForTest = {0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0}; //todo <--- good
            // int[] cluesForTest = {0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0};  //todo <--- good
            // int[] cluesForTest = {0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0};  //todo <--- good
            // int[] cluesForTest = {4, 4, 0, 3, 0, 0, 0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0};  //todo <--- good
            // int[] cluesForTest = {0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0};
            // int[] cluesForTest = {0, 0, 0, 0, 0, 0, 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            // int[] cluesForTest = {1, 5, 5, 5, 5, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            // int[] cluesForTest = {0, 2, 0, 0, 0, 0,   4, 0, 4, 2, 0, 0,   0, 0, 0, 0, 4, 3,    4, 0, 2, 0, 0, 0}; //todo <--- good


            // int[] cluesForTest = {3, 2, 3, 2, 3, 1, 1, 2, 3, 2, 2, 4, 3, 2, 2, 1, 2, 4, 3, 2, 2, 1, 3, 3};
            // int[] cluesForTest = {0, 0, 0, 0, 0, 0, 3, 0, 0, 3, 4, 0, 0, 0, 0, 0};


            // int[] cluesForTest = {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //todo <--- good
            // int[] cluesForTest =
            //     {0, 0, 0, 2, 2, 0, 0, 0, 0, 6, 3, 0, 0, 4, 0, 0, 0, 0, 4, 4, 0, 3, 0, 0}; //todo <--- good
            // int[] cluesForTest =
            //     {0, 2, 0, 0, 0, 0,    4, 0, 4, 2, 0, 0,    0, 0, 0, 0, 4, 3,    4, 0, 2, 0, 0, 0}; //todo <--- good
            // int[] cluesForTest =
            //     {3, 0, 3, 3, 0, 0,    0, 1, 3, 0, 2, 0,    0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0}; //todo <--- good

            // int[] cluesForTest =  {0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0,    3, 0, 3, 3, 0, 0,    0, 1, 3, 0, 2, 0};






            // todo zero
            // int[] cluesForTest =  {3, 0, 3, 3, 0, 0,    0, 1, 3, 0, 2, 0,    0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{4,1}, "3");
            // dictFortest.Add(new int[]{5,2}, "2");

            // todo one
            // int[] cluesForTest =  {0, 1, 3, 0, 2, 0,    0, 3, 2, 0, 4, 0,    0, 0, 0, 3, 0, 0,    3, 0, 3, 3, 0, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{4,4}, "3");
            // dictFortest.Add(new int[]{3,5}, "2");
            // SolvePuzzle(cluesForTest, true, dictFortest);

            // int[] cluesForTest =  {0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{4,4}, "3");
            // SolvePuzzle(cluesForTest, true, dictFortest);


            // int[] cluesForTest =  {0, 2, 2, 2, 0, 4,    0, 4, 2, 0, 0, 0,    0, 3, 2, 0, 4, 0,    3, 0, 0, 0, 0, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{3,2}, "4");
            // dictFortest.Add(new int[]{4,4}, "1");
            // // dictFortest.Add(new int[]{3,5}, "1");
            // SolvePuzzle(cluesForTest, true, dictFortest);



            // int[] cluesForTest =  {0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0,    0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{1,1}, "3");
            // SolvePuzzle(cluesForTest, true, dictFortest);

            // int[] cluesForTest =  {0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0};
            // var dictFortest = new Dictionary<int[], string>();
            // dictFortest.Add(new int[]{4,4}, "3");
            // SolvePuzzle(cluesForTest, true, dictFortest);

            // int[] cluesForTest =  {2, 0, 0, 1,    0, 3, 0, 3,    0, 0, 0, 0,    0, 2, 0, 0};
            // SolvePuzzle(cluesForTest, true);
            // SolvePuzzle(MoveLeft(cluesForTest));
            // SolvePuzzle(MoveLeft(MoveLeft(cluesForTest)));


            int[] cluesForTest =  {0, 0, 0, 0,    0, 2, 0, 0,    2, 0, 0, 0,   0, 3, 0, 3};
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SkyScrapersAll.SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);

            string[][] board =
            {
                new [] {"1", "2", "4", "3"},
                new [] {"3", "4", "1", "2"},
                new [] {"2", "13", "3", "14"},
                new [] {"4", "13", "2", "1"},
            };
            SkyScrapersAll.IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, 4);


        }


        public static int[][] SolvePuzzle(int[] clues, bool dfsOn = true, Dictionary<int[], string> readySets = null)
        {
            var Max = clues.Length / 4;
            var board = new string[Max][];
            int[] upClues;
            int[] rightClues;
            int[] bottomClues;
            int[] leftClues;
            SetClues(clues, out upClues, out rightClues, out bottomClues, out leftClues);
            MakeEmptyBoard(board, Max);
            SetUpEdge(board, upClues, Max);
            SetRightEdge(board, rightClues, Max);
            SetBottomEdge(board, bottomClues, Max);
            SetLeftEdge(board, leftClues, Max);
            RemoveMaxAndOneClues(new List<int[]> {upClues, rightClues, bottomClues, leftClues}, Max);
            FillAndRemoveAllReadyFromCrossSets(board, Max);
            RemoveSecondTallestSkyscraperFromEdgeClueTwo(board, upClues, rightClues, bottomClues, leftClues, Max);

            DisplayBoard(board, Max, upClues, rightClues, bottomClues, leftClues);
            ScanAll(ref board, upClues, rightClues, bottomClues, leftClues, Max);
            DisplayBoard(board, Max, upClues, rightClues, bottomClues, leftClues);

            if (dfsOn)
            {
                board = DFS(board, upClues, rightClues, bottomClues, leftClues, Max, readySets);
            }

            if (board.Length != 1)
            {
                DisplayBoard(board, Max, upClues, rightClues, bottomClues, leftClues);
            }
            else
            {
                Console.WriteLine("Not resolved !!!");
                return new int[1][];
            }
            return MakeAnswer(board, Max);
        }

        private static string[][] DFS(string[][] board, int[] upClues, int[] rightClues, int[] bottomClues,
            int[] leftClues, int Max, Dictionary<int[], string> readySets = null)
        {
            // todo if false then false
            if (board.Length == 1)
            {
                Console.WriteLine("Return bad from beginning DFS");
                return board;
            }

            // todo if ok then return board
            if (board.SelectMany(s => s).Count(s => s.Length == 1) == Max * Max)
            {
                Console.WriteLine("Return ok from beginning DFS");
                return board;
            }

            // todo copy board find smallest set
            var firstSmallestSetX = 0;
            var firstSmallestSetY = 0;
            string copySmallestSet;

            var sizeOfSmallestSet = board
                .SelectMany(s => s)
                .Where(s => s.Length > 1)
                .GroupBy(s => s.Length)
                .Select((k, a) => k.Key)
                .Min();

            for (var y = 0; y < Max; y++)
            {
                for (var x = 0; x < Max; x++)
                {
                    if (board[y][x].Length != sizeOfSmallestSet) continue;
                    copySmallestSet = board[y][x];
                    foreach (var oneNumberForTest in copySmallestSet)
                    {
                        string[][] copyBoard = board.Select(s => s.ToArray()).ToArray();
                        copyBoard[y][x] = oneNumberForTest.ToString();
                        DisplayBoard(copyBoard, Max, upClues, rightClues, bottomClues, leftClues);
                        if (!RemoveSettedNumberNew(ref copyBoard, y, x, upClues, rightClues, bottomClues, leftClues,
                            null, Max))
                        {
                            DisplayBoard(copyBoard, Max, upClues, rightClues, bottomClues, leftClues);
                            continue;
                        }

                        DisplayBoard(copyBoard, Max, upClues, rightClues, bottomClues, leftClues);
                        // todo add handle comibination two  !!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        // if (!IsBoardDevelopmental(copyBoard, upClues, rightClues, bottomClues, leftClues, Max))
                        // {
                        //     continue;
                        // }
                        var nextBoard = DFS(copyBoard, upClues, rightClues, bottomClues, leftClues, Max, readySets);
                        if (nextBoard.Length != 1
                            && nextBoard.SelectMany(s => s).Count(s => s.Length == 1) == Max * Max
                            && IsBoardDevelopmental(nextBoard, upClues, rightClues, bottomClues, leftClues, Max)
                            && (
                                readySets != null
                                && readySets.All(readySet => nextBoard[readySet.Key[0]][readySet.Key[1]].
                                    Contains(readySet.Value))
                                || readySets == null)
                        )
                        {
                            Console.WriteLine("return 100% OK from FOR");
                            return nextBoard;
                        }
                    }

                    Console.WriteLine("Return bad from end FOR DFS ");
                    return new string[1][];
                }
            }

            Console.WriteLine("Return bad from end DFS <--- not resolved ");
            return new string[1][];
        }


        public static bool RemoveSettedNumberNew(
            ref string[][] board,
            int Y,
            int X,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            bool? columnOrRow, //todo true column
            int Max)
        {
            var settedNumber = board[Y][X][0];
            var coordinatesNewSettedNumbers = new List<int[]>();
            var coordinatesToFind = new List<int[]>();
            if (columnOrRow == null || columnOrRow == false) // todo ROW
            {
                for (var x = 0; x < Max; x++) //todo search row Y
                {
                    if (X == x || !board[Y][x].Contains(settedNumber)) continue;
                    board[Y][x] = board[Y][x].Replace(settedNumber.ToString(), "");
                    if (!IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, Max))
                        return false; // todo check if ok when after for ???
                    if (board[Y][x].Length != 1) coordinatesToFind.Add(new[] {-1, x});
                    if (board[Y][x].Length == 1) coordinatesNewSettedNumbers.Add(new[] {Y, x});
                    // todo break ??
                }
            }

            if (columnOrRow == null || columnOrRow == true) // todo COLUMN
            {
                for (var y = 0; y < Max; y++) //todo search row Y
                {
                    if (Y == y || !board[y][X].Contains(settedNumber)) continue;
                    board[y][X] = board[y][X].Replace(settedNumber.ToString(), "");
                    DisplayBoard(board, Max, upClues, rightClues, bottomClues, leftClues);
                    if (!IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, Max))
                        return false; // todo check if ok when after for ???
                    if (board[y][X].Length != 1) coordinatesToFind.Add(new[] {y, -1});
                    if (board[y][X].Length == 1) coordinatesNewSettedNumbers.Add(new[] {y, X});
                    // todo break ??
                }
            }
            DisplayBoard(board, Max, upClues, rightClues, bottomClues, leftClues);
            foreach (var coordinatesNewSettedNumber in coordinatesNewSettedNumbers)
            {
                if (!RemoveSettedNumberNew(
                    ref board,
                    coordinatesNewSettedNumber[0],
                    coordinatesNewSettedNumber[1],
                    upClues,
                    rightClues,
                    bottomClues,
                    leftClues,
                    null,
                    Max)) return false;
            }

            foreach (var coordinateToFind in coordinatesToFind)
            {
                if (!FindAloneAndSetNew(ref board, coordinateToFind[0], coordinateToFind[1], upClues,
                    rightClues, bottomClues, leftClues, Max)) return false;
            }
            return true;
        }


        private static bool FindAloneAndSetNew(
            ref string[][] board,
            int Y,
            int X,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            var coordinatesNewSettedNumbers = new List<int[]>();
            if (Y > -1) //todo find in ROW !!!
            {
                var rowOrColumn = board[Y];

                var alone = FindAloneLogic(rowOrColumn);
                if (!string.IsNullOrEmpty(alone))
                {
                    for (var x = 0; x < Max; x++)
                    {
                        if (!board[Y][x].Contains(alone)) continue;
                        board[Y][x] = alone;
                        if (!IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, Max))
                            return false;
                        if (alone.Length == 1) coordinatesNewSettedNumbers.Add(new[] {Y, x});
                        if (alone.Length != 1) break;
                    }
                }
            }

            if (X > -1) //todo find in COLUMN !!!
            {
                var rowOrColumn = new string[Max];
                for (var y = 0; y < Max; y++) rowOrColumn[y] = board[y][X];

                var alone = FindAloneLogic(rowOrColumn);
                if (!string.IsNullOrEmpty(alone))
                {
                    for (var y = 0; y < Max; y++)
                    {
                        if (!board[y][X].Contains(alone)) continue;
                        board[y][X] = alone;
                        if (!IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, Max))
                            return false;
                        if (alone.Length == 1) coordinatesNewSettedNumbers.Add(new[] {y, X});
                        if (alone.Length != 1) break;
                    }
                } //todo pass!!!
            }

            foreach (var coordinatesNewSettedNumber in coordinatesNewSettedNumbers)
            {
                if (!RemoveSettedNumberNew(
                    ref board,
                    coordinatesNewSettedNumber[0],
                    coordinatesNewSettedNumber[1],
                    upClues,
                    rightClues,
                    bottomClues,
                    leftClues,
                    null,
                    Max)) return false;
            }

            foreach (var coordinatesNewSettedNumber in coordinatesNewSettedNumbers)
            {
                if (!FindAloneAndSetNew(ref board, coordinatesNewSettedNumber[0], coordinatesNewSettedNumber[1],
                    upClues,
                    rightClues, bottomClues, leftClues, Max)) return false;
            }

            return true;
        }


        private static string FindAloneLogic(string[] rowOrColumn)
        {
            var alone = string.Join("", rowOrColumn
                .Where(s => s.Length != 1)
                .SelectMany(s => s)
                .GroupBy(c => c)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .Where(a => !rowOrColumn
                    .Where(s => s.Length == 1)
                    .SelectMany(s => s)
                    .Contains(a)));
            return alone;
        }


        private static void ScanAll(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            var forTest = 0;
            for (var y = 0; y < Max; y++)
            {
                FindAloneAndSetNew(ref board, y, -1, upClues, rightClues, bottomClues, leftClues, Max);
            }

            for (var x = 0; x < Max; x++)
            {
                FindAloneAndSetNew(ref board, -1, x, upClues, rightClues, bottomClues, leftClues, Max);
            }

            HandleCombinationsWithClueTwo(ref board, upClues, rightClues, bottomClues, leftClues,
                Max); //todo for check DFS
        }


        public static bool IsBoardDevelopmental(string[][] board, int[] upClues, int[] rightClues, int[] bottomClues,
            int[] leftClues, int Max)
        {
            if (board.SelectMany(s => s).Any(s => s.Equals(""))) return false;

            // todo upClues
            for (var x = 0; x < Max; x++)
            {
                var column = new string[Max];
                for (int y = Max - 1, i = 0; y >= 0; y--, i++) column[i] = board[y][x];
                if (IsDuplicates(column, Max)) return false;
                if (upClues[x] == 0) continue;
                if (IsWrongClue(column, upClues[x], Max)) return false;
            }

            // todo rightClues
            for (var y = 0; y < Max; y++)
            {
                if (IsDuplicates(board[y], Max)) return false;
                if (rightClues[y] == 0) continue;
                if (IsWrongClue(board[y], rightClues[y], Max)) return false;
            }

            // todo bottomClues
            for (var x = 0; x < Max; x++)
            {
                var column = new string[Max];
                for (int y = 0, i = 0; y < Max; y++, i++) column[i] = board[y][x];
                if (IsDuplicates(column, Max)) return false;
                if (bottomClues[x] == 0) continue;
                if (IsWrongClue(column, bottomClues[x], Max)) return false;
            }

            // todo leftClues
            for (var y = 0; y < Max; y++)
            {
                var row = new string[Max];
                for (int x = Max - 1, i = 0; x >= 0; x--, i++) row[i] = board[y][x];
                if (IsDuplicates(row, Max)) return false;
                if (leftClues[y] == 0) continue;
                if (IsWrongClue(row, leftClues[y], Max)) return false;
            }

            return true;
        }


        private static bool IsDuplicates(string[] column, in int Max)
        {
            if (column.Count(s => s.Length == 1) == Max)
            {
                if (column
                        .GroupBy(s => s)
                        .Select(g => g.Key)
                        .Count() != Max)
                {
                    return true;
                }
            }

            return false;
        }


        public static bool IsWrongClue(string[] columnOrRow, int clue, int Max)
        {
            var lastMax = 0;
            var countVisible = 0;
            var within = true;
            for (var i = Max - 1; i >= 0; i--)
            {
                var actual = int.Parse(columnOrRow[i]);
                if (columnOrRow[i].Length != 1) within = false;
                if (columnOrRow[i].Length != 1 || actual <= lastMax) continue;
                lastMax = actual;
                countVisible++;
                if (within && countVisible > clue) return true;
                if (within && lastMax == Max && countVisible != clue) return true;
            }

            return false;
        }


        private static void RemoveMaxAndOneClues(List<int[]> listOfClues, int Max)
        {
            foreach (var clues in listOfClues)
            {
                for (var i = 0; i < Max; i++)
                {
                    if (clues[i] == 1 || clues[i] == Max) clues[i] = 0;
                }
            }
        }


        private static bool HandleCombinationsWithClueTwo(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            if (!HandleUpCluesTwo(ref board, upClues, rightClues, bottomClues, leftClues, Max)) return false;
            if (!HandleRightCluesTwo(ref board, upClues, rightClues, bottomClues, leftClues, Max)) return false;
            if (!HandleBottomCluesTwo(ref board, upClues, rightClues, bottomClues, leftClues, Max)) return false;
            if (!HandleLeftCluesTwo(ref board, upClues, rightClues, bottomClues, leftClues, Max)) return false;
            return true;
        }


        private static bool HandleUpCluesTwo(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            for (var x = 0; x < Max; x++)
            {
                if (upClues[x] != 2) continue;
                var column = new string[Max];
                for (int y = Max - 1, i = 0; y >= 0; y--, i++) column[i] = board[y][x];
                if (SetHighestNextToAdjacentClueTwoLogic(ref column, Max))
                {
                    for (int y = Max - 1, i = 0; y >= 0; y--, i++)
                    {
                        if (column[i] != Max.ToString()) continue;
                        board[y][x] = column[i];
                        if (!RemoveSettedNumberNew(ref board, y, x, upClues, rightClues, bottomClues, leftClues, null,
                            Max))
                            return false;
                        // RemoveAlone(board, y, -1, Max.ToString()[0], Max);
                        // RemoveAlone(board, -1, x, Max.ToString()[0], Max);
                        break;
                    }
                }

                if (!SetSecondHighestOppositeClueTwoLogic(ref column, Max)) continue;
                board[0][x] = column[Max - 1];
                if (!RemoveSettedNumberNew(ref board, 0, x, upClues, rightClues, bottomClues, leftClues, null, Max))
                    return false;
                // RemoveAlone(board, 0, -1, board[0][x][0], Max);
                // RemoveAlone(board, -1, x, board[0][x][0], Max);
            }

            return true;
        }


        private static bool HandleRightCluesTwo(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                if (rightClues[y] != 2) continue;
                if (SetHighestNextToAdjacentClueTwoLogic(ref board[y], Max))
                {
                    for (var x = 0; x < Max; x++)
                    {
                        if (board[y][x] != Max.ToString()) continue;
                        if (!RemoveSettedNumberNew(ref board, y, x, upClues, rightClues, bottomClues, leftClues, null,
                            Max))
                            return false;
                        // RemoveAlone(board, y, -1, Max.ToString()[0], Max);
                        // RemoveAlone(board, -1, x, Max.ToString()[0], Max);
                        break;
                    }
                }

                ;
                if (!SetSecondHighestOppositeClueTwoLogic(ref board[y], Max)) continue;
                if (!RemoveSettedNumberNew(ref board, y, Max - 1, upClues, rightClues, bottomClues, leftClues, null,
                    Max))
                    return false;
                // RemoveAlone(board, y, -1, board[y][Max - 1][0], Max);
                // RemoveAlone(board, -1, Max - 1, board[y][Max - 1][0], Max);
            }

            return true;
        }


        private static bool HandleBottomCluesTwo(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            for (var x = 0; x < Max; x++)
            {
                if (bottomClues[x] != 2) continue;
                var column = new string[Max];
                for (int y = 0, i = 0; y < Max; y++, i++) column[i] = board[y][x];
                if (SetHighestNextToAdjacentClueTwoLogic(ref column, Max))
                {
                    for (int y = 0, i = 0; y < Max; y++, i++)
                    {
                        if (column[i] != Max.ToString()) continue;
                        board[y][x] = column[i];
                        if (!RemoveSettedNumberNew(ref board, y, x, upClues, rightClues, bottomClues, leftClues, null,
                            Max))
                            return false;
                        // RemoveAlone(board, y, -1, Max.ToString()[0], Max);
                        // RemoveAlone(board, -1, x, Max.ToString()[0], Max);
                        break;
                    }
                }

                if (!SetSecondHighestOppositeClueTwoLogic(ref column, Max)) continue;
                board[Max - 1][x] = column[Max - 1];
                if (!RemoveSettedNumberNew(ref board, Max - 1, x, upClues, rightClues, bottomClues, leftClues, null,
                    Max))
                    return false;
                // RemoveAlone(board, Max - 1, -1, board[Max - 1][x][0], Max);
                // RemoveAlone(board, -1, x, board[Max - 1][x][0], Max);
            }

            return true;
        }


        private static bool HandleLeftCluesTwo(
            ref string[][] board,
            int[] upClues,
            int[] rightClues,
            int[] bottomClues,
            int[] leftClues,
            int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                if (leftClues[y] != 2) continue;
                var row = new string[Max];
                for (int x = Max - 1, i = 0; x >= 0; x--, i++) row[i] = board[y][x];
                if (SetHighestNextToAdjacentClueTwoLogic(ref row, Max))
                {
                    for (int x = Max - 1, i = 0; x >= 0; x--, i++)
                    {
                        if (row[i] != Max.ToString()) continue;
                        board[y][x] = row[i];
                        if (!RemoveSettedNumberNew(ref board, y, x, upClues, rightClues, bottomClues, leftClues, null,
                            Max))
                            return false;
                        // RemoveAlone(board, y, -1, Max.ToString()[0], Max);
                        // RemoveAlone(board, -1, x, Max.ToString()[0], Max);
                        break;
                    }
                }

                if (!SetSecondHighestOppositeClueTwoLogic(ref row, Max)) continue;
                board[y][0] = row[Max - 1];
                if (!RemoveSettedNumberNew(ref board, y, 0, upClues, rightClues, bottomClues, leftClues, null, Max))
                    return false;
                // RemoveAlone(board, y, -1, board[y][0][0], Max);
                // RemoveAlone(board, -1, 0, board[y][0][0], Max);
            }

            return true;
        }


        public static bool SetHighestNextToAdjacentClueTwoLogic(ref string[] columnOrRow, int Max)
        {
            if (columnOrRow.Any(s => s.Equals(Max.ToString()))) return false;
            if (columnOrRow[Max - 1].Length != 1) return false;
            var ready = columnOrRow.Where(s => s.Length == 1).Select(int.Parse).ToArray();
            Array.Sort(ready);
            if (ready[ready.Length - 1] != ready.Length) return false;
            for (var i = columnOrRow.Length - 1; i >= 0; i--)
            {
                if (columnOrRow[i].Length == 1) continue;
                columnOrRow[i] = Max.ToString();
                return true;
            }

            return false;
        }


        public static bool SetSecondHighestOppositeClueTwoLogic(ref string[] columnOrRow, int Max)
        {
            if (columnOrRow.Count(s => s.Length == 1) == Max) return false;
            if (columnOrRow.Last().Length == 1) return false;
            if (!columnOrRow.Where(s => s.Length == 1).Any(s => s.Equals(Max.ToString()))) return false;
            if (columnOrRow[0] == Max.ToString())
            {
                columnOrRow[Max - 1] = "" + columnOrRow.Last()[columnOrRow.Last().Length - 1];
                return true;
            }

            var testOrder = false;
            foreach (var set in columnOrRow)
            {
                if (testOrder == false && set.Length == 1) continue;
                if (set.Length > 1 && testOrder == false) testOrder = true;
                if (set.Length == 1) return false;
            }

            if (!testOrder) return false;
            columnOrRow[Max - 1] = "" + columnOrRow.Last()[columnOrRow.Last().Length - 1];
            return true;
        }


        private static void RemoveSecondTallestSkyscraperFromEdgeClueTwo(
            string[][] board,
            IReadOnlyList<int> upClues,
            IReadOnlyList<int> rightClues,
            IReadOnlyList<int> bottomClues,
            IReadOnlyList<int> leftClues,
            int Max)
        {
            for (var x = 0; x < Max; x++)
            {
                if (upClues[x] == 2) board[1][x] = board[1][x].Replace((Max - 1).ToString(), "");
            }

            for (var y = 0; y < Max; y++)
            {
                if (rightClues[y] == 2) board[y][Max - 2] = board[y][Max - 2].Replace((Max - 1).ToString(), "");
            }

            for (var x = 0; x < Max; x++)
            {
                if (bottomClues[x] == 2) board[Max - 2][x] = board[Max - 2][x].Replace((Max - 1).ToString(), "");
            }

            for (var y = 0; y < Max; y++)
            {
                if (leftClues[y] == 2) board[y][1] = board[y][1].Replace((Max - 1).ToString(), "");
            }
        }


        private static void FillAndRemoveAllReadyFromCrossSets(
            IReadOnlyList<string[]> board,
            int Max)
        {
            var lastNumbersOfAllSets = 0;
            while (board.SelectMany(s => s).Select(s => s.Length).Sum() != lastNumbersOfAllSets)
            {
                lastNumbersOfAllSets = board.SelectMany(s => s).Select(s => s.Length).Sum();
                for (var y = 0; y < Max; y++)
                {
                    for (var x = 0; x < Max; x++)
                    {
                        if (board[y][x].Length == 1) continue;
                        board[y][x] = ReturnSetWithOutReadyFields(board, y, x, Max);
                    }
                }
            }
        }


        private static string ReturnSetWithOutReadyFields(IReadOnlyList<string[]> board, int y, int x, int Max)
        {
            var answer = new StringBuilder(board[y][x].Length == 0
                ? string.Join("", (Enumerable.Range(1, Max).Select(n => n.ToString())))
                : board[y][x]);
            for (var xTemp = 0; xTemp < Max; xTemp++)
            {
                if (board[y][xTemp].Length == 1) answer.Replace(board[y][xTemp], "");
            }

            for (var yTemp = 0; yTemp < Max; yTemp++)
            {
                if (board[yTemp][x].Length == 1) answer.Replace(board[yTemp][x], "");
            }

            return answer.ToString();
        }


        private static void SetUpEdge(
            string[][] board,
            IReadOnlyList<int> upClues,
            int Max)
        {
            for (var x = 0; x < Max; x++)
            {
                if (upClues[x] == 1)
                {
                    board[0][x] = "";
                    board[0][x] = Max.ToString();
                }
                else if (upClues[x] == Max)
                {
                    for (var y = 0; y < Max; y++)
                    {
                        board[y][x] = "";
                        board[y][x] = (y + 1).ToString();
                    }
                }
                else if (upClues[x] != 0)
                {
                    for (int y = 0, i = 0; y < Max; y++, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Length == 0 ||
                             board[y][x].Length > Enumerable.Range(1, Max - upClues[x] + 1).Count())
                        )
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - upClues[x] + 1).Select(n => n.ToString()));
                        }
                        else if (Max - upClues[x] + 1 + i < Max &&
                                 (board[y][x].Length == 0 ||
                                  board[y][x].Length > Enumerable.Range(1, Max - upClues[x] + 1 + i).Count()))
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - upClues[x] + 1 + i).Select(n => n.ToString()));
                        }
                    }
                }
            }
        }


        private static void SetRightEdge(
            string[][] board,
            IReadOnlyList<int> rightClues,
            int Max)
        {
            for (var y = 0; y < rightClues.Count; y++)
            {
                if (rightClues[y] == 1)
                {
                    board[y][Max - 1] = "";
                    board[y][Max - 1] = Max.ToString();
                }
                else if (rightClues[y] == Max)
                    for (var x = Max - 1; x >= 0; x--)
                    {
                        board[y][x] = "";
                        board[y][x] = (Max - x).ToString();
                    }
                else if (rightClues[y] != 0)
                {
                    for (int x = Max - 1, i = 0; x >= 0; x--, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Length == 0 ||
                             board[y][x].Length > Enumerable.Range(1, Max - rightClues[y] + 1).Count())
                        )
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - rightClues[y] + 1).Select(n => n.ToString()));
                        }
                        else if (Max - rightClues[y] + 1 + i < Max &&
                                 (board[y][x].Length == 0 ||
                                  board[y][x].Length > Enumerable.Range(1, Max - rightClues[y] + 1 + i).Count()))
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - rightClues[y] + 1 + i).Select(n => n.ToString()));
                        }
                    }
                }
            }
        }


        private static void SetBottomEdge(
            string[][] board,
            IReadOnlyList<int> bottomClues,
            int Max)
        {
            for (var x = Max - 1; x >= 0; x--)
            {
                if (bottomClues[x] == 1)
                {
                    board[Max - 1][x] = "";
                    board[Max - 1][x] = Max.ToString();
                }
                else if (bottomClues[x] == Max)
                    for (var y = Max - 1; y >= 0; y--)
                    {
                        board[y][x] = "";
                        board[y][x] = (Max - y).ToString();
                    }
                else if (bottomClues[x] != 0)
                {
                    for (int y = Max - 1, i = 0; y >= 0; y--, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Length == 0 ||
                             board[y][x].Length > Enumerable.Range(1, Max - bottomClues[x] + 1).Count())
                        )
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - bottomClues[x] + 1).Select(n => n.ToString()));
                        }
                        else if (Max - bottomClues[x] + 1 + i < Max &&
                                 (board[y][x].Length == 0 ||
                                  board[y][x].Length > Enumerable.Range(1, Max - bottomClues[x] + 1 + i).Count()))
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - bottomClues[x] + 1 + i).Select(n => n.ToString()));
                        }
                    }
                }
            }
        }


        private static void SetLeftEdge(
            string[][] board,
            IReadOnlyList<int> leftClues,
            int Max)
        {
            for (var y = 0; y < leftClues.Count; y++)
            {
                if (leftClues[y] == 1)
                {
                    board[y][0] = "";
                    board[y][0] = Max.ToString();
                }
                else if (leftClues[y] == Max)
                    for (var x = 0; x < Max; x++)
                    {
                        board[y][x] = "";
                        board[y][x] = (x + 1).ToString();
                    }
                else if (leftClues[y] != 0)
                {
                    for (int x = 0, i = 0; x < Max - 1; x++, i++)
                    {
                        if (i == 0 &&
                            (board[y][x].Length == 0 ||
                             board[y][x].Length > Enumerable.Range(1, Max - leftClues[y] + 1).Count())
                        )
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - leftClues[y] + 1).Select(n => n.ToString()));
                        }
                        else if (Max - leftClues[y] + 1 + i < Max &&
                                 (board[y][x].Length == 0 ||
                                  board[y][x].Length > Enumerable.Range(1, Max - leftClues[y] + 1 + i).Count()))
                        {
                            board[y][x] = string.Join("",
                                Enumerable.Range(1, Max - leftClues[y] + 1 + i).Select(n => n.ToString()));
                        }
                    }
                }
            }
        }


        public static void SetClues(
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


        private static void MakeEmptyBoard(string[][] board, int Max)
        {
            for (var y = 0; y < Max; y++)
            {
                board[y] = new string[Max];
                for (var x = 0; x < Max; x++)
                {
                    board[y][x] = "";
                }
            }
        }


        private static int[][] MakeAnswer(string[][] board, int Max)
        {
            var answer = new int[Max][];
            for (var y = 0; y < Max; y++)
            {
                answer[y] = new int[Max];
                for (var x = 0; x < Max; x++)
                {
                    answer[y][x] = int.Parse(board[y][x]);
                }
            }

            return answer;
        }


        private static void DisplayBoard(IEnumerable<string[]> board, in int Max, int[] upClues = null,
            int[] rightClues = null,
            int[] bottomClues = null, int[] leftClues = null)
        {
            if (upClues != null)
            {
                Console.WriteLine("   " + string.Join(new string(' ', Max + 1), upClues).Replace('0', '.'));
                Console.WriteLine("   " + new string('-', Max * Max + Max * 2));
                var i = 0;
                foreach (var row in board)
                {
                    Console.Write((leftClues[i] + " |").Replace('0', '.'));
                    foreach (var n in row)
                    {
                        Console.Write(n.PadRight(Max + 2));
                    }

                    Console.WriteLine(("| " + rightClues[i++]).Replace('0', '.'));
                }

                Console.WriteLine("   " + new string('-', Max * Max + Max * 2));
                Console.WriteLine("   " + string.Join(new String(' ', Max + 1), bottomClues).Replace('0', '.'));
                Console.WriteLine(board.SelectMany(s => s).Sum(s => s.Length) + " <--- all numbers in board");
            }
            else
            {
                Console.WriteLine("   " + new string('-', Max * Max + Max * 2));
                var i = 0;
                foreach (var row in board)
                {
                    Console.Write(" |");
                    foreach (var n in row)
                    {
                        Console.Write(n.PadRight(Max + 2));
                    }

                    Console.WriteLine("| ");
                }

                Console.WriteLine("   " + new string('-', Max * Max + Max * 2));
                Console.WriteLine(board.SelectMany(s => s).Sum(s => s.Length) + " <--- all numbers in board");
            }
        }

        public static int[][] RotateLeft(int[][] board)
        {
            var Max = board.Length;
            var answer = new int[Max][];
            var i = 0;
            for (var x = Max - 1; x >= 0; x--)
            {
                answer[i] = new int[Max];
                for (var y = 0; y < Max; y++)
                {
                    answer[i][y] = board[y][x];
                }
                i++;
            }
            return answer;
        }

        public static T[] MoveLeft<T>(T[] clues)
        {
            var Max = clues.Length / 4;
            var answer = new T[clues.Length];
            var j = 0;

            for (var i = Max; i < clues.Length; i++) answer[j++] = clues[i];
            for (var i = 0; i < Max; i++) answer[j++] = clues[i];
            return answer;
        }
    }


}


// string[][] test =
// {
//     new []{"3", "4", "12", "2"},
//     new []{"123", "123", "12345", "123"},
//     new []{"123", "123", "1235", "123"},
//     new []{"5", "134", "1345", "2", "1345", "6"}
// };
// foreach (var one in test)
// {
//     var alone = string.Join("", one
//         .Where(s => s.Length != 1)
//         .SelectMany(s => s)
//         .GroupBy(c => c)
//         .Where(g => g.Count() == 1)
//         .Select(g => g.Key)
//         .Where(a => !one.Where(s => s.Length == 1).SelectMany(s => s).Contains(a)));
//
//
//     Console.WriteLine(alone);
// }

// string[][] expected =
// {
//     new [] {"1235", "1236", "1236", "4", "135", "235"},
//     new [] {"12345", "1236", "1236", "12", "1346", "2345"},
//     new [] {"1234", "123", "1236", "12", "13456", "2345"},
//     new [] {"6", "5", "4", "3", "2", "1"},
//     new [] {"123", "123", "5", "6", "134", "234"},
//     new [] {"123", "4", "123", "5", "13", "6"}
// };
//
// var copyExpected = expected.Select(s => s.ToArray()).ToArray();
// copyExpected[0][0] = "666";
// string testStringCopy = copyExpected[0][0];
// testStringCopy = "777";
//
// Console.WriteLine(expected[0][0]);
// Console.WriteLine(copyExpected[0][0]);
// Console.WriteLine(testStringCopy);
//
//
// var smallestSet = expected
//     .SelectMany(s => s)
//     .Where(s => s.Length > 1)
//     .GroupBy(s => s.Length)
//     .Select((k, a) => k.Key)
//     .Min();
// Console.WriteLine(smallestSet + " <---smallestSet");
// foreach (var one in expected
//     .SelectMany(s => s)
//     .Where(s => s.Length > 1)
//     .GroupBy(s => s.Length)
//     .Select( (k, a) => k.Key))
// {
//     Console.WriteLine(one);
// }
// string[] columnOrRow = {"65", "6", "4", "3", "2", "1"};
// string[] columnOrRow = {"5", "6", "4", "3", "2", "1"};
// var toPrint = columnOrRow
//     .Where(s => s.Length == 1)
//     .GroupBy(s => s)
//     .Select(s => s.Key)
//     .Count();
// Console.WriteLine(toPrint);
// Console.WriteLine(columnOrRow
//                       .Count(s => s.Length == 1) == 6);
// Console.WriteLine(columnOrRow
//                       .GroupBy(s => s)
//                       .Select(g => g.Key)
//                       .Count() != 6);
// Console.WriteLine(columnOrRow
//                       .Count(s => s.Length == 1) == 6
//                   && columnOrRow
//                       .GroupBy(s => s.Length)
//                       .Select(g => g.Key).Sum() != 6);


// Console.WriteLine(smallestSet);


// string[][] forTest =
// {
//     new [] {"6", "1", "5", "2", "4", "3"},
//     new [] {"2", "4", "6", "5", "3", "1"},
//     new [] {"1", "2", "3", "4", "5", "6"},
//     new [] {"3", "356", "1", "36", "2", "4"}, // todo first 3 get stack overfloo
//     new [] {"4", "36", "2", "136", "16", "5"},
//     new [] {"35", "35", "4", "136", "16", "2"}
// };
// // SkyScrapersAll.RemoveAlone(forTest, 3, -1, '3', 6);
// int[] upClues;
// int[] rightClues;
// int[] bottomClues;
// int[] leftClues;
//
// SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);
// SkyScrapersAll.RemoveSettedNumberNew(ref forTest, 3, 0, upClues, rightClues, bottomClues, leftClues, null, 6);
// Console.WriteLine("test");








            // int[] cluesForTest =  {2, 0, 0, 1,    0, 3, 0, 3,    0, 0, 0, 0,    0, 2, 0, 0};
            // SolvePuzzle(cluesForTest, true);


            // int[] cluesForTest =  {0, 3, 2, 0, 0, 5,    0, 0, 4, 0, 0, 0,    0, 0, 0, 2, 0, 3,    0, 0, 0, 3, 4, 0};
            // int[] upClues;
            // int[] rightClues;
            // int[] bottomClues;
            // int[] leftClues;
            // SetClues(cluesForTest, out upClues, out rightClues, out bottomClues, out leftClues);
            //
            //
            // var board = new string[][]
            // {
            //     new string []{"4", "2",    "5",     "3",       "6",       "1",},
            //     new string []{"1", "3",    "4",     "6",       "5",       "2",},
            //     new string []{"2", "4",    "6",     "45",      "1",       "3",},
            //     new string []{"6", "145",  "123",   "1245",    "234",     "45",},
            //     new string []{"5", "146",  "123",   "124",     "234",     "46",},
            //     new string []{"3", "1456", "12",    "1245",    "24",      "456",},
            // };
            // var y = 2;
            // var x = 1;
            //
            // if (!RemoveSettedNumberNew(ref board, y, x, upClues, rightClues, bottomClues, leftClues,
            //     null, 6))
            //     Console.WriteLine("asdfasdf");
            // ;


            // var board = new string[][]
            // {
            //     new string []{"6", "3",    "5",     "1",       "4",       "2",},
            //     new string []{"1", "2",    "4",     "6",       "5",       "3",},
            //     new string []{"3", "4",    "6",     "5",      "2",       "1",},
            //     new string []{"5", "1",  "2",   "3",    "6",     "4",},
            //     new string []{"2", "6",  "1",   "4",     "3",     "5",},
            //     new string []{"4", "5", "3",    "2",    "1",      "6",},
            // };


            // Console.WriteLine(IsBoardDevelopmental(board, upClues, rightClues, bottomClues, leftClues, 6));