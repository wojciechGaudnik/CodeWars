using System;

namespace Katas
{
    public static class MatrixDeterminant
    {
        private static int Determinant(int[,] input)
        {
            var order = int.Parse(Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                var value = 0;
                for (var j = 0; j < order; j++)
                {
                    var temp = CreateSmallerMatrix(input, 0, j);
                    value += input[0, j] * (SignOfElement(0, j) * Determinant(temp));
                }
                return value;
            }
            if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            return (input[0, 0]);
        }

        private static int[,] CreateSmallerMatrix(int[,] input, int i, int j)
        {
            var order = int.Parse(Math.Sqrt(input.Length).ToString());
            var output = new int[order - 1, order - 1];
            var x = 0;
            for (var m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    var y = 0;
                    for (var n = 0; n < order; n++)
                    {
                        if (n == j) continue;
                        output[x, y] = input[m, n];
                        y++;
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }

        private static int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            return -1;
        }


//todo faster !!!! ----------------------
        public static int Determinant(int[][] matrix)
        {
            var convert = new int[matrix.Length, matrix.Length];
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix.Length; j++)
                {
                    convert[i, j] = matrix[i][j];
                }
            }
            return DeterminantOfMatrix(convert, matrix.Length);
        }

        private static int DeterminantOfMatrix(int [,]mat, int n)
        {
            var d = 0;
            if (n == 1)
                return mat[0, 0];
            var temp = new int[n, n];
            var sign = 1;
            for (var f = 0; f < n; f++)
            {
                GetCofactor(mat, temp, 0, f, n);
                d += sign * mat[0, f] * DeterminantOfMatrix(temp, n - 1);
                sign = -sign;
            }
            return d;
        }

        private static void GetCofactor(int [,]mat, int [,]temp, int p, int q, int n)
        {
            int i = 0, j = 0;
            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    if (row == p || col == q) continue;
                    temp[i, j++] = mat[row, col];
                    if (j != n - 1) continue;
                    j = 0;
                    i++;
                }
            }
        }

    }
}