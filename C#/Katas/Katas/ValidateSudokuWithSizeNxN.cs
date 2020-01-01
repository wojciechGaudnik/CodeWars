using System;
using System.Linq;

namespace Katas
{
    public class ValidateSudokuWithSizeNxN
    {
        public static void Main(string[] args)
        {
            ValidateSudokuWithSizeNxN test = new ValidateSudokuWithSizeNxN(
                new int[][] {
                    new int[] {7,8,4, 1,5,9, 3,2,6},
                    new int[] {5,3,9, 6,7,2, 8,4,1},
                    new int[] {6,1,2, 4,3,8, 7,5,9},

                    new int[] {9,2,8, 7,1,5, 4,6,3},
                    new int[] {3,5,7, 8,4,6, 1,9,2},
                    new int[] {4,6,1, 9,2,3, 5,8,7},

                    new int[] {8,7,6, 3,9,4, 2,1,5},
                    new int[] {2,4,3, 5,6,1, 9,7,8},
                    new int[] {1,9,5, 2,8,7, 6,3,4}
                });
            var test2 = new ValidateSudokuWithSizeNxN(
                new int[][] {
                    new int[] {1,4, 2,3},
                    new int[] {3,2, 4,1},

                    new int[] {4,1, 3,2},
                    new int[] {2,3, 1,4}
                });
            Console.WriteLine(test.IsValid());
            Console.WriteLine(test2.IsValid());

        }

        private int[][] sudoku;
        private int[] good;
        private int[] test;
        private int i;
        private int N;
        private int n;

        public ValidateSudokuWithSizeNxN(int[][] sudokuData)
        {
            sudoku = sudokuData;
        }

        public bool IsValid()
        {
            if(sudoku == null || sudoku.Length == 0) return false;
            if(!TestSimple()) return false;

            good = Enumerable.Range(1, sudoku.Length).ToArray();
            test = new int[good.Length];
            i = 0;
            n = (int) Math.Sqrt(sudoku.Length);
            N = sudoku.Length;

            return TestVertical() && TestHorizontal() && TestSquare();
        }

        private bool TestVertical()
        {
            for (var x = 0; x < N; x++)
            {
                for (var y = 0; y < N; y++)
                {
                    test[i++] = sudoku[x][y];
                }
                if (!Test()) return false;
            }
            return true;
        }

        private bool TestHorizontal()
        {
            for (var y = 0; y < N; y++)
            {
                for (var x = 0; x < N; x++)
                {
                    test[i++] = sudoku[x][y];
                }
                if (!Test()) return false;
            }
            return true;
        }

        private bool TestSquare()
        {
            for (int X = 0, Y = 0; X < N; X += n, Y += n)
            {
                for (var x = X; x < X + n; x++)
                {
                    for (var y = Y; y < Y + n; y++)
                    {
                        test[i++] = sudoku[x][y];
                    }
                }
                if (!Test()) return false;
            }
            return true;
        }

        private bool TestSimple()
        {
            return !(Math.Abs(Math.Sqrt(sudoku.Length) % 1) > 0.000000000001)
                   && sudoku.All(row => row.Length == sudoku.Length)
                && sudoku.All(row => row.All(i => i % 1 == 0));
        }

        private bool Test()
        {
            Array.Sort(test);
            if (!good.SequenceEqual(test)) return false;
            i = 0;
            return true;
        }
    }
}