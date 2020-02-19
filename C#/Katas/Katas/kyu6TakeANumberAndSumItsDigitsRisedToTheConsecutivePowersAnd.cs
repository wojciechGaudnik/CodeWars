using System;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6TakeANumberAndSumItsDigitsRisedToTheConsecutivePowersAnd
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> answer = new List<long>();
            for (var i = a; i <= b; i++)
            {
                double sum = 0;
                var pow = 1;
                foreach (var one in i.ToString())
                {
                    sum += Math.Pow(double.Parse(one.ToString()), pow++);
                }
                if(sum == i) answer.Add(i);
            }
            return answer.ToArray();
        }
    }
}