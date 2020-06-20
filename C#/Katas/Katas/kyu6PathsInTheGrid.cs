using System.Numerics;

namespace Katas
{
    public class kyu6PathsInTheGrid
    {
        public static BigInteger NumberOfRoutes(int m, int n)
        {
            return Factorial(m + n) / (Factorial(n) * Factorial(m));
        }
        private static BigInteger Factorial(BigInteger number) =>
            (number > 0) ? number * Factorial(number - 1): BigInteger.One;
    }
}