using System;
using System.Collections.Generic;

namespace Katas
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            Console.WriteLine(array);
            Console.WriteLine(array[0]);
            if(array.Length == 0 || array[0].Length == 0) return new int[]{};
            List<int> answer = new List<int>();
            int size = array.Length * array.Length;
            int top = 0;
            int right = array.Length;
            int bottom = array.Length;
            int left = 0;
            int x = 0;
            int y = 0;

            while (answer.Count != size)
            {
                for (; x < right; x++)
                {
                    answer.Add(array[y][x]);
                }
                if(answer.Count == size) return answer.ToArray();
                x--;
                y++;
                top++;


                for (; y < bottom; y++)
                {
                    answer.Add(array[y][x]);
                }
                if(answer.Count == size) return answer.ToArray();
                x--;
                y--;
                right--;

                for (; x >= left; x--)
                {
                    answer.Add(array[y][x]);
                }
                if(answer.Count == size) return answer.ToArray();
                x++;
                y--;
                bottom--;

                for (; y >= top; y--)
                {
                    answer.Add(array[y][x]);
                }
                if(answer.Count == size) return answer.ToArray();
                x++;
                y++;
                left++;
            }
            return answer.ToArray();
        }
    }
}