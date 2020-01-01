using System;
using System.Linq;

namespace Katas
{
    public class MagnetParticulesInBoxes
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(Doubles(1, 3).Equals(0.4236111111111111));
            // Console.WriteLine(Doubles(1, 10).Equals(0.5580321939764581));
            // Console.WriteLine(Doubles(10, 100).Equals(0.6832948559787737));
            Console.WriteLine(Doubles2(10, 100));
        }

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