using System;

namespace Katas
{
    public class kyu6ParabolicArcLength
    {
        public static double lenCurve(int n)
        {
            var h = 1.0 / n;
            double sum = 0;
            double x2 = 0;
            double y2 = 0;
            while (n-- > 0)
            {
                double y1, x1;
                (x1, y1) = (x2, y2);
                x2 += h;
                y2 = x2 * x2;
                sum += Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
            return Math.Truncate(1000000000 * sum) / 1000000000;
        }
    }
}