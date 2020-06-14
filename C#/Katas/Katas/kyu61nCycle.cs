using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu61nCycle
    {
        public static void Main(string[] args)
        {


            // Console.WriteLine((decimal)1/7);
            // Console.WriteLine((decimal)1/11);
            // Console.WriteLine((decimal)1/13);
            // Console.WriteLine((decimal)1/94);



            var n = 13;
            var multiplier = Math.Pow(10, 4);
            // multiplier = 10000000000000000;
            var counter = new BigInteger(0.1 * multiplier);
            var denominator = new BigInteger(n);
            var decimalString2 = BigInteger.Divide(counter, denominator);
            Console.WriteLine(decimalString2);
            // Console.WriteLine(Running(33));
            // Console.WriteLine(Running(18118));
            // Console.WriteLine(Running(69));
            Console.WriteLine(Running(n));
        }

        public static int Running(int n)
        {
            if (n % 2 == 0 || n % 5 == 0) return -1;
            var i = 1;
            var answer = 1;
            for (;; ++i)
            {
                answer = answer * 10 % n;
                if (answer == 1) return i;
            }
        }
    }
}