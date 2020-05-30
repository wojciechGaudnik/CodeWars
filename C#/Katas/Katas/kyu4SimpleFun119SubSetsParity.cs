using System;
using System.Collections;
using System.Numerics;
using System.Timers;

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
            // Console.WriteLine(watch.ElapsedMilliseconds + "ms");
            // Console.WriteLine(((Math.Pow(10, 10) / 2) / 8 ) / 1000);
            // Console.WriteLine(5 >> 1);
            // Console.WriteLine(Math.Sqrt(5));
        }

        public string SubsetsParity(int n, int k)
        {
            if (n == k) return "ODD";
            while (k != 0)
            {
                if (n % 2 == 0 && k % 2 == 1) return "EVEN";
                k /= 2;
                n /= 2;
            }
            return "ODD";
        }

        public string SubsetsParity321(int n, int k) //todo 4 ms
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            var l = new BigInteger(n);
            var m = new BigInteger(1);
            for (var i = 1; i < k; i++)
            {
                l *= --n;
                m *= i + 1;
                if (l % 2 == 0 && m % 2 == 1) return "EVEN";
            }
            return (BigInteger.Divide(l, m)) % 2 == 0 ? "EVEN" : "ODD";
        }


        private bool[][] pOET;

        // public kyu4SimpleFun119SubSetsParity()
        // {
        //     var size = (int) Math.Pow(10, 6);
        //     pOET = new bool[size][];
        //     pOET[0] = new []{true};
        //     pOET[1] = new []{true, true};
        //     for (var n = 2 ;n < size; n++)
        //     {
        //         Console.WriteLine(n);
        //         pOET[n] = new bool[n + 1];
        //         pOET[n][0] = true;
        //         pOET[n][n] = true;
        //         for (var k = 1; k < n; k++)
        //         {
        //             pOET[n][k] = pOET[n - 1][k - 1] ^ pOET[n - 1][k];
        //         }
        //     }
        // }


        public string SubsetsParity22(int n, int k) //todo 2.7 s
        {
            if (n == 1 || n == k ) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            if (k > n - k) k = n - k;

            var last = new []{true, false, true};
            var next = new bool[last.Length + 1];
            for (var ni = 2; ni < n; ni++)
            {
                var lastLength = last.Length;
                next = new bool[lastLength + 1];
                next[0] = true;
                for (var kj = 1; kj < lastLength; kj++)
                {
                    next[kj] = last[kj - 1] ^ last[kj];
                }
                next[lastLength] = true;
                last = next;
                Console.WriteLine(ni + " <---");
            }
            return next[k] ? "ODD" : "EVEN";
        }






        public string SubsetsParity222(int n, int k) //todo 4 ms
        {
            Console.WriteLine("n=" + n + "  k=" + k);
            if (k == n || k == 0) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            if (k > n - k) k = n - k;
            var l = new BigInteger(n);
            var m = new BigInteger(1);
            for (var i = 1; i < k; i++)
            {
                l *= --n;
                m *= i + 1;
            }
            return (BigInteger.Divide(l, m)) % 2 == 0 ? "EVEN" : "ODD";
        }


        public string SubsetsParity11(int n, int k) //todo much too long
        {
            return binomialCoeff(n, k) ? "ODD" : "EVEN";
        }


        static bool binomialCoeff(int n, int k)
        {
            Console.WriteLine(n + " " + k);
            if (k == 0 || k == n)
                return true;
            return binomialCoeff(n - 1, k - 1) ^
                   binomialCoeff(n - 1, k);
        }

        public static string SubsetsParity2_7(int n, int k) //todo 2.7 s
        {
            if (n == 1 || n == k ) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            if (k > n - k) k = n - k;

            var last = new []{true, false, true};
            var next = new bool[last.Length + 1];
            for (var ni = 2; ni < n; ni++)
            {
                var lastLength = last.Length;
                next = new bool[lastLength + 1];
                next[0] = true;
                for (var kj = 1; kj < lastLength; kj++)
                {
                    next[kj] = last[kj - 1] ^ last[kj];
                }
                next[lastLength] = true;
                last = next;
                Console.WriteLine(ni + " <---");
            }
            return next[k] ? "ODD" : "EVEN";
        }

        public string SubsetsParity5(int n, int k) //todo 4 ms
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            var l = new BigInteger(n);
            for (var i = 1; i < k; i++){ l *= --n;}
            var m = new BigInteger(1);
            for (var i = 2; i <= k; i++){m *= i;}
            return (BigInteger.Divide(l, m)) % 2 == 0 ? "EVEN" : "ODD";
        }

        public string SubsetsParity484(int n, int k) //todo 477 ms
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";

            var nk = n - k;
            var nS = new BigInteger();
            nS = 1;
            var nkS = new BigInteger();
            var kS = new BigInteger();
            var i = 1;
            while (i <= n)
            {
                nS *= i;
                if (i == k) kS = nS;
                if (i++ == nk) nkS = nS;
            }
            var answer = BigInteger.Divide(nS, BigInteger.Multiply(kS, nkS));
            return answer % 2 == 0 ? "EVEN" : "ODD";
        }

        // public string SubsetsParity(int n, int k)

        // {

        //     if(n == k) return "ODD";

        //     var nk = n - k;

        //     var nS = new BigInteger();

        //     nS = 1;

        //     var nkS = new BigInteger();

        //     nkS = 1;

        //     var kS = new BigInteger();

        //     kS = 1;

        //     var i = 1;

        //

        //     if (k < nk)

        //     {

        //         while (i <= k) kS *= ++i;

        //         nkS = kS;

        //         while (i <= nk) nkS *= ++i;

        //         nS = nkS;

        //         while (i <= n) nS *= ++i;

        //     }

        //     else

        //     {

        //         while (i <= nk) nkS *= ++i;

        //         nS = nkS;

        //         while (i <= k) kS *= ++i;

        //         nkS = kS;

        //         while (i <= n) nS *= ++i;

        //     }

        //

        //     Console.WriteLine(nS + " " + kS + " " + nkS);

        //

        //     var answer = BigInteger.Divide(nS, BigInteger.Multiply(kS, nkS));

        //     return answer % 2 == 0 ? "EVEN" : "ODD";

        // }
    }


}