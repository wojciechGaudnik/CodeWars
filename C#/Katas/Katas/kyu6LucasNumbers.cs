using System;

namespace Katas
{
    public class kyu6LucasNumbers
    {
        public static long lucasnum(int n)
        {
            long n0 = 2;
            long n1 = 1;
            if (n == 0) return n0;
            if (n == 1) return n1;
            if (n == -1) return -n1;
            var wasMinus = n < 0;
            n = Math.Abs(n);
            long next = 0;
            for (long i = 2; i <= n; i++)
            {
                next = n0 + n1;
                (n0, n1) = (n1, next);
            }

            if (wasMinus && n % 2 == 1) return -next;
            return next;
        }
    }
}