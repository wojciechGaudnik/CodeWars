using System;

namespace Katas
{
    public class kyu5NumberOfTrailingZerosOfN
    {
        public static int TrailingZeros(int n)
        {
            var answer = 0;
            for (var k = 1; k <= Math.Log(n, 5); k++)
            {
                answer += (int)(n / Math.Pow(5, k));
            }
            return answer;
        }
    }
}