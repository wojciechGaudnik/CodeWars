using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5IntegersRecreationOne
    {
        public static string listSquared(long m, long n)
        {
            var dict = new Dictionary<long, double>();
            for (var i = m; i <= n; i++)
            {
                var sumOfPowDivisors = Divisors(i)
                    .Select(n => Math.Pow(n, 2))
                    .Aggregate((a, b) => a + b);
                if (Math.Abs((Math.Sqrt(sumOfPowDivisors) % 1)) < 0.00000000000000000001) dict.Add(i, sumOfPowDivisors);
            }
            return "[" + string.Join(", ", dict) + "]";
        }

        private static List<long> Divisors(long n)
        {
            var list = new List<long>();
            for (var i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i != 0) continue;
                if (n / i == i) list.Add(i);
                else
                {
                    list.Add(i);
                    list.Add(n / i);
                }
            }
            return list;
        }
    }
}