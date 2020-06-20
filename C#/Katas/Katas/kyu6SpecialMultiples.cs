using System;
using System.Collections;
using System.Linq;

namespace Katas
{
    public class kyu6SpecialMultiples
    {
        public static long CountSpecMult(long n, long mxval)
        {
            var sum = Convert.ToInt64(
                GeneratePrimes(n)
                    .ToArray()
                    .Aggregate((l, n) => Convert.ToInt64(l) * Convert.ToInt64(n)));
            return mxval / sum;
        }

        private static ArrayList GeneratePrimes(long toGenerate)
        {
            ArrayList primes = new ArrayList();
            primes.Add(2);
            primes.Add(3);
            while (primes.Count < toGenerate)
            {
                var nextPrime = (int)(primes[^1]) + 2;
                while (true)
                {
                    var isPrime = primes.Cast<int>().All(n => nextPrime % n != 0);
                    if (isPrime) break;
                    nextPrime += 2;
                }
                primes.Add(nextPrime);
            }
            return primes;
        }


    }
}