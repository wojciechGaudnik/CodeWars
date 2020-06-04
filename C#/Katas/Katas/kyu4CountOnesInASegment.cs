using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Katas
{
    public class kyu4CountOnesInASegment
    {
        // public static void Main(string[] args)
        // {
        //     Console.WriteLine(CountOnesBF(0, 12));
        //     // Console.WriteLine(CountOnes(93960293923410, 153413882626292));
        // }

        public static BigInteger CountOnes(long left, long right) //todo 11.3 sek
        {
            return CountFrom0ToNumberBigger(right) - CountFrom0ToNumberBigger(left) + Convert.ToString(left, 2).Count(c => c == '1');
        }

        private static BigInteger CountFrom0ToNumberBigger(long number)
        {
            BigInteger leftSum = 0;
            var numberBuff = number;
            while (true)
            {
                Console.WriteLine(numberBuff);
                BigInteger partSum = Convert.ToString(numberBuff, 2).Count(c => c == '1');
                if (partSum == 1)
                {
                    leftSum += CountFrom0ToNumber(numberBuff);
                    break;
                }
                leftSum += partSum;
                numberBuff--;
            }
            return leftSum;
        }

        private static BigInteger CountFrom0ToNumber(BigInteger number)
        {
            BigInteger countFromO = 1;
            BigInteger sequence = 0;
            for (BigInteger n = 1; n < number; n <<= 1)
            {
                countFromO = countFromO * 2 + sequence;
                sequence = sequence * 2 + 1;
            }

            return countFromO;
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


