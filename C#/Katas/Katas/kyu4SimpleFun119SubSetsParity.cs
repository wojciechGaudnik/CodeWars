using System;

namespace Katas
{
    public class kyu4SimpleFun119SubSetsParity
    {
        public static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var testKata = new kyu4SimpleFun119SubSetsParity();
            Console.WriteLine(testKata.SubsetsParity(85, 55));

            watch.Stop();
        }

        public string SubsetsParity(int n, int k)
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            while (k != 0)
            {
                k /= 2;
                n /= 2;
                if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            }
            return "ODD";
        }
    }
}