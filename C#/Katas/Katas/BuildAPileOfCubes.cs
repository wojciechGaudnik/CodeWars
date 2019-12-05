using System;

namespace Katas
{
    public class BuildAPileOfCubes
    {
        static void Main(string[] args)
        {
            int m = 1071225;
            Console.WriteLine(findNb(4183059834009));

        }

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