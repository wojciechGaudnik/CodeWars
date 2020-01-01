using System;
using System.Linq;

namespace Katas
{
    public class ValidateSudokuWithSizeNxN
    {
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