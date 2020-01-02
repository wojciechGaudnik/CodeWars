using System;
using System.Linq;

namespace Katas
{
    public class MagnetParticulesInBoxes
    {
        public static double Doubles2(int maxk, int maxn)
        {
            double sum = 0.0;
            for (var k = 1; k <= maxk; k++)
            {
                for (var n = 1; n <= maxn ; n++)
                {
                    sum += 1.0 / (k * Math.Pow((n + 1),(2 * k)));
                }
            }
            return sum;
        }

        public static double Doubles(int maxk, int maxn)
        {
            return Enumerable.Range(1, maxk)
                .Select(k => Enumerable.Range(1, maxn)
                    .Select(n => 1.0 / (k * Math.Pow((n + 1), (2 * k)))))
                .SelectMany(e => e)
                .Sum();
        }
    }
}