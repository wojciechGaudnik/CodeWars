using System;

namespace Katas
{
    public class kyu6StepsInPrimes
    {
        public static long[] Step(int g, long m, long n)
        {
            for (var f = m; f + g <= n; f++)
            {
                if (IsPrime(f) && IsPrime(f + g))
                {
                    return new []{f, f + g};
                }
            }
            return null;
        }

        private static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            var limit = Math.Ceiling(Math.Sqrt(number));
            for (var i = 2; i <= limit; ++i)  {
                if (number % i == 0)  return false;
            }
            return true;
        }

    }
}