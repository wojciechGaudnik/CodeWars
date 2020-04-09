using System;

namespace Katas
{
    public class kyu6RowOfTheOddTriangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(OddRow(13));
        }

        public static long[] OddRow(int n)
        {
            if(n == 1) return new long[]{1};
            long nn = n;
            var first = (long) Math.Pow(n, 2) - (n - 1);
            var answer = new long[n];

            for(var i = 0; i < nn; i++)
            {
                answer[i] = first;
                first += 2;
            }
            return answer;
        }

    }
}