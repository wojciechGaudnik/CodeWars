using System;
using System.Linq;

namespace Katas
{
    public class kyu6PyramidArray
    {
        public static void Main(string[] args)
        {
            foreach (var one in Pyramid(1))
            {
                Console.WriteLine(one);
            }
        }

        public static int[][] Pyramid(int n) {
            if ( n == 0 ) return new int[0][];
            var answer = new int[n][];
            for (var i = 0; i < n; i++)
            {
                answer[i] = Enumerable.Repeat(1, i + 1).ToArray();
            }
            return Enumerable.Range(1, n).Select(i => Enumerable.Repeat(1, i).ToArray()).ToArray();
        }

    }
}