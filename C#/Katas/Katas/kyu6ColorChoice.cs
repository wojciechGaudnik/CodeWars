using System.Numerics;
using System.Text;

namespace Katas
{
    public class kyu6ColorChoice
    {
        public static long Checkchoose(long m, int n)
        {
            var x = 0;
            while (++x < n)
            {
                var fnB = BigInteger.Parse(Factorial(n));
                var fxB = BigInteger.Parse(Factorial(x));
                var fnxB = BigInteger.Parse(Factorial(n - x));
                if (m == (fnB / (fxB * fnxB))) return x;
            }
            return -1;
        }


        private static string Factorial(int n)
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
            return answer.ToString();
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