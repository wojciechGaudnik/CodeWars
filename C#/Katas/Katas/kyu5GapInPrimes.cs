using System;

namespace Katas
{
    public class kyu5GapInPrimes
    {
        public static long[] Gap(int g, long m, long n)
        {
            long lastPrim = -1;
            for (var i = m; i < n; i++)
            {
                if (!IsPrime(i)) continue;
                if (lastPrim == -1) lastPrim = i;
                else if (i - lastPrim == g) return new[] {lastPrim, i};
                else lastPrim = i;
            }
            return null;
        }

        private static bool IsPrime(long num)
        {
            if (num <= 6) return num == 2 || num == 3 || num == 5;
            if ((num & 1) == 0 || num % 3 == 0) return false;

            var l = Math.Floor(Math.Sqrt(num));
            for (var i = 5; i <= l; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0) return false;
            }
            return true;
        }
    }
}