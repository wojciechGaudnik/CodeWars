using System;

namespace Katas
{
    public class PyramidSlideDown
    {
        public static int LongestSlideDown(int[][] pyramid)
        {
            var maxI = pyramid.Length;
            var square = new int[pyramid.Length, pyramid.Length + 1];
            for (var i = 0; i < pyramid.Length; i++)
            {
                for (var j = 0; j < pyramid[i].Length; j++)
                {
                    square[i, j] = pyramid[i][j];
                }
            }

            for (var i = maxI - 2; i >= 0; i--)
            {
                for (var j = 0; j < maxI; j++)
                {
                    square[i, j] = Math.Max(
                        square[i, j] +
                        square[i + 1, j],
                        square[i, j] +
                        square[i + 1, j + 1]);
                }
            }
            return square[0, 0];
        }
    }
}