using System;
using System.Numerics;

namespace Katas
{
    public class kyu4SimpleFun119SubSetsParity
    {
        // public static void Main(string[] args)
        // {
        //     var testKata = new kyu4SimpleFun119SubSetsParity();
        //     // Console.WriteLine(testKata.SubsetsParity(61, 5));
        //     // Console.WriteLine(testKata.SubsetsParity2(61, 5));
        //     // Console.WriteLine(testKata.SubsetsParity(3, 2));
        //     // Console.WriteLine(testKata.SubsetsParity2(3, 2) + " <--- OK ");
        //
        //     // n p k p            n
        //     // n p k n            o
        //     // n n k p            n
        //     // n n k n            n
        //     // for (var n = 1001; n < 10001; n += 2)
        //     // {
        //     //     for (var k = 11; k < 1000; k += 2)
        //     //     {
        //     //         Console.WriteLine(testKata.SubsetsParity(n, k));
        //     //     }
        //     // }
        //
        //     // for (int n = 11, k = 11; k <= n && n < 10000; n += 1)
        //     // {
        //     //     {
        //     //         Console.WriteLine(testKata.SubsetsParity(n, k) + " n:" + n + " k:" + k + " (n - k) % 2 ---> " + ((n % k) % 2));
        //     //     }
        //     // }
        //     // testKata.SubsetsParity(52, 5);
        //     testKata.SubsetsParity(52, 5);
        //
        //
        //     // Console.WriteLine(testKata.SubsetsParity(81, 15) + " EVEN <--- OK ");
        // }

        public string SubsetsParity1(int n, int k) //todo 4 ms
        {
            if (n == k) return "ODD";
            // if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            var answer = 1;
            for (var i = 1; i <= k; i++)
            {
                answer *= (n + 1 - i) / i;
            }
            return (answer) % 2 == 0 ? "EVEN" : "ODD";
        }


        public string SubsetsParity(int n, int k) //todo 4 ms
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            var l = new BigInteger(n);
            for (var i = 1; i < k; i++){ l *= --n;}
            var m = new BigInteger(1);
            for (var i = 2; i <= k; i++) m *= i;
            return (BigInteger.Divide(l, m)) % 2 == 0 ? "EVEN" : "ODD";
        }

        public string SubsetsParity2(int n, int k) //todo 477 ms
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
            // Console.WriteLine(nS + " " + kS + " " + nkS);
            var answer = BigInteger.Divide(nS, BigInteger.Multiply(kS, nkS));
            Console.WriteLine(answer);
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