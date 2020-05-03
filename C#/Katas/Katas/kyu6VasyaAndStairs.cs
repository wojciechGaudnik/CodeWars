using System;

namespace Katas
{
    public class kyu6VasyaAndStairs
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(NumberOfSteps(10, 2));
            // Console.WriteLine(NumberOfSteps(3, 5));
            Console.WriteLine(NumberOfSteps(18, 10));
            Console.WriteLine(NumberOfSteps(21, 10));
            Console.WriteLine(NumberOfSteps(2, 2));
        }

        public static int NumberOfSteps(int n, int m)
        {
            var rest = 0;
            var minSteps = n / 2 + (n % 2);
            while ((minSteps + rest) % m != 0 && n > 0)
            {
                rest++;
                n--;
                minSteps = n / 2 + (n % 2);
            }
            if (n <= 0) return -1;
            return minSteps + rest;
        }


    }
}