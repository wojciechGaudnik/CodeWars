using System;

namespace Katas
{
    public class kyu6RoundByHalfSteps
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solution(4.6));
        }

        public static double Solution(double n)
        {
            return Math.Round(n / 0.5) * 0.5;
        }
    }
}