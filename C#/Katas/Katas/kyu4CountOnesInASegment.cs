using System;
using System.Linq;
using System.Numerics;

namespace Katas
{
    public class kyu4CountOnesInASegment
    {
        public static BigInteger CountOnes(long left, long right) //todo 11.3 sek
        {
            return
                CountFrom0ToProperNumber(right) -
                CountFrom0ToProperNumber(left) +
                Convert.ToString(left, 2).Count(c => c == '1');
        }

        private static BigInteger CountFrom0ToProperNumber(long number)
        {
            if (number == 0) return 0;
            if (number == 1) return 1;
            var numberBinary = Convert.ToString(number, 2);
            var numberNearestPowerOfTwo = Convert.ToInt64("1" + new String('0', numberBinary.Length - 1), 2);
            var numberNext = Convert.ToInt64(numberBinary.Substring(1), 2);
            return CountFrom0ToNumberPowerOfTwo(numberNearestPowerOfTwo) + (number - numberNearestPowerOfTwo) + CountFrom0ToProperNumber(numberNext);
        }

        private static BigInteger CountFrom0ToNumberPowerOfTwo(BigInteger number)
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
    }
}


