using System;
using System.Linq;

namespace Katas
{
    public class BuildAPileOfCubes
    {
        static void Main(string[] args)
        {
            int[] test = {1,2,3,4,};
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
            int x = test[0];
            x = 10;
            Console.WriteLine();
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
            ref int x2 =ref test[0];
            x2 = 10;
            Console.WriteLine();
            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));



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