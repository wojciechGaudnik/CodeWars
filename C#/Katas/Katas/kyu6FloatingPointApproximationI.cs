using System;

namespace Katas
{
    public class kyu6FloatingPointApproximationI
    {
        public static double f(double x)
        {
            return x / (1 + Math.Sqrt(1 + x));
        }
    }
}