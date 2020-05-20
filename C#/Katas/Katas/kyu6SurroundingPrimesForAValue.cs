using System;

namespace Katas
{
    public class kyu6SurroundingPrimesForAValue
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", PrimeBefAft(1693)));
        }

        public static long[] PrimeBefAft(long num)
        {
            var smaller = num;
            var greater = num;
            while (!isPrime(--smaller)) {};
            while (!isPrime(++greater)) {};
            return new []{smaller, greater};
        }

        private static bool isPrime(long num)
        {
            for (var i = 2; i < num/2; i++) if (num % i == 0) return false;
            return true;
        }
    }
}