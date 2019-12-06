using System;

namespace Katas
{
    public class BuildAPileOfCubes
    {
        public static long findNb(long m) {
            long n = 1;
            long part = 0;
            while (part < m)
            {
                part += (long)Math.Pow(n, 3);
                if (part == m) return n;
                n++;
            }
            return -1;
        }
    }
}