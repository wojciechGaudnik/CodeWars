using System;
using System.Linq;

namespace Katas
{
    public class SudokuSolutionValidator
    {
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