using System;
using System.Data.Common;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Katas
{
    public class kyu4CountOnesInASegment
    {
        // public static void Main(string[] args)
        // {
        //     // int worker = 0;
        //     // int io = 0;
        //     // ThreadPool.GetAvailableThreads(out worker, out io);
        //     //
        //     // Console.WriteLine("Thread pool threads available at startup: ");
        //     // Console.WriteLine("   Worker threads: {0:N0}", worker);
        //     // Console.WriteLine("   Asynchronous I/O threads: {0:N0}", io);
        //     // Console.WriteLine(sumOnes(0, 4));
        //     // Console.WriteLine(sumOnes(0, 8));
        //     // Console.WriteLine(sumOnes(4, 8));
        //     // Console.WriteLine(sumOnes(4, 7));
        //
        //     // long test = 1;
        //     // for (var i = 0; i < 65; i++)
        //     // {
        //     //     Console.WriteLine(i + " <-> " + test + " <-> " +  Convert.ToString(test, 2) + " <-> " + CountOnesBF(0, test));
        //     //     test = test << 1;
        //     // }
        //
        //
        //     // double sum = 0;
        //     // var places = 5;
        //     // for (var i = 1; i <= places; i++)
        //     // {
        //     //     Console.WriteLine(Factorial(i));
        //     //     // sum += BigInteger.Divide(Factorial(places), Factorial(places - i));
        //     // }
        //
        //     // Console.WriteLine(sum + 1);
        //     Console.WriteLine(CountOnesBF(0, 32));
        //     Console.WriteLine(Factorial(5) / Factorial(1));
        //     Console.WriteLine(Factorial(5) / Factorial(2));
        //     Console.WriteLine(Factorial(5) / Factorial(3));
        //     Console.WriteLine(Factorial(5) / Factorial(4));
        //     Console.WriteLine(Factorial(5) / Factorial(5));
        // }

        public static BigInteger CountOnes(long left, long right)
        {
            return new BigInteger();
        }

        public static BigInteger CountOnesBF(long left, long right)
        {
            BigInteger sum = 0;
            for (var i = left; i <= right; i++)
            {
                sum += Convert.ToString(i, 2).Count(c => c == '1');
            }
            return sum;
        }

        public static BigInteger Factorial(int n)
        {
            var res = new int[500];
            res[0] = 1;
            var resSize = 1;
            for (var x = 2; x <= n; x++)
                resSize = Multiply(x, res, resSize);
            var answer = new StringBuilder();
            for (var i = resSize - 1; i >= 0; i--)
            {
                answer.Append(res[i]);
            }
            return BigInteger.Parse(answer.ToString());
        }

        private static int Multiply(int x, int []res, int resSize)
        {
            var carry = 0;
            for (var i = 0; i < resSize; i++)
            {
                var prod = res[i] * x + carry;
                res[i] = prod % 10;
                carry = prod / 10;
            }
            while (carry != 0)
            {
                res[resSize] = carry % 10;
                carry /= 10;
                resSize++;
            }
            return resSize;
        }


    }
}


