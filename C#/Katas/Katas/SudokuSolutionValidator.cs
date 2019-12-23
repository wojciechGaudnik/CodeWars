using System;
using System.Linq;

namespace Katas
{
    public class SudokuSolutionValidator
    {
        public static void Main(string[] args)
        {
            int[][] test =
            {
                new int []{5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int []{6, 7, 2, 1, 9, 5, 3, 4, 8},
                new int []{1, 9, 8, 3, 4, 2, 5, 6, 7},
                new int []{8, 5, 9, 7, 6, 1, 4, 2, 3},
                new int []{4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int []{7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int []{9, 6, 1, 5, 3, 7, 2, 8, 4},
                new int []{2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int []{3, 4, 5, 2, 8, 6, 1, 7, 9}
            };
            int[][] test2 =
            {
                new int []{5, 3, 4, 6, 7, 8, 9, 1, 2},
                new int []{6, 7, 2, 1, 9, 0, 3, 4, 8},
                new int []{1, 0, 0, 3, 4, 2, 5, 6, 0},
                new int []{8, 5, 9, 7, 6, 1, 0, 2, 0},
                new int []{4, 2, 6, 8, 5, 3, 7, 9, 1},
                new int []{7, 1, 3, 9, 2, 4, 8, 5, 6},
                new int []{9, 0, 1, 5, 3, 7, 2, 1, 4},
                new int []{2, 8, 7, 4, 1, 9, 6, 3, 5},
                new int []{3, 0, 0, 4, 8, 1, 1, 7, 9}
            };

            Console.WriteLine(ValidateSolution(test));
            Console.WriteLine(ValidateSolution(test2));
        }

        public static bool ValidateSolution(int[][] board)
        {
            int[] good = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] test = new int[9];
            int x, y, i = 0;
            if (!TestVertical(board, test, good, ref i)) return false;

            if (!TestHorizontal(board, test, good, ref i)) return false;

            return TestSquers(board, test, i, good);
        }

        private static bool TestSquers(int[][] array, int[] test, int i, int[] good)
        {
            for (int X = 0, Y = 0; X < 9; X += 3, Y += 3)
            {
                for (var x = X; x < X + 3; x++)
                {
                    for (var y = Y; y < Y + 3; y++)
                    {
                        test[i++] = array[x][y];
                    }
                }

                if (!Test(test, good, ref i)) return false;
            }

            return true;
        }

        private static bool TestHorizontal(int[][] array, int[] test, int[] good, ref int i)
        {
            for (var y = 0; y < 9; y++)
            {
                for (var x = 0; x < 9; x++)
                {
                    test[i++] = array[x][y];
                }

                if (!Test(test, good, ref i)) return false;
            }

            return true;
        }

        private static bool TestVertical(int[][] array, int[] test, int[] good, ref int i)
        {
            for (var x = 0; x < 9; x++)
            {
                for (var y = 0; y < 9; y++)
                {
                    test[i++] = array[x][y];
                }

                if (!Test(test, good, ref i)) return false;
            }

            return true;
        }

        private static bool Test(int[] test, int[] good, ref int i)
        {
            Array.Sort(test);
            if (!good.SequenceEqual(test)) return false;
            i = 0;
            return true;
        }
    }
}