using System;

namespace Katas
{
    public class kyu6FloatingPointApproximationI
    {
        public static void Main(string[] args)
        {
            var x = 1e-15;
            Console.WriteLine(x / (1 + Math.Sqrt(1 + x)));

        }

        public static double f(double x)
        {
            return x / (1 + Math.Sqrt(1 + x));
        }
    }
}