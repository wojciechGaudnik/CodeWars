using System;
using System.Numerics;

namespace Katas
{
    public class kyu5PerimeterOfSquaresInaRectangle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(perimeter(7) * 4);

        }

        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger firstFib = 1;
            BigInteger midFib = 1;
            BigInteger lastFib = 2;

            while (n-- >= 0)
            {
                lastFib = firstFib + midFib;
                firstFib = midFib;
                midFib = lastFib;
            }
            return (lastFib - 1) * 4;
        }

        private static BigInteger fib(BigInteger n)
        {
            if (n == 1) return 1;
            return 444;
        }
    }
}