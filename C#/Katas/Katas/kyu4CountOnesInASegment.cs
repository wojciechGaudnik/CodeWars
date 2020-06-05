using System;
using System.Linq;
using System.Numerics;

namespace Katas
{
    public class kyu4CountOnesInASegment
    {
        public static void Main(string[] args)
        {
            // for (var i = 0; i < 50; i++)
            // {
            //     var text = "";
            //     text += Convert.ToString(i, 2) + "  ";
            //     text += "CountOnesBF i=" + i + " " + CountOnesBF(0, i) + " <---> ";
            //     text += "CountFrom0ToNumber " + CountFrom0ToNumber(i);
            //     text += ((Convert.ToString(i, 2).Count(c => c == '1') == 1)
            //         ? "<--"
            //         : "");
            //
            //     Console.WriteLine(text);
            // }
            //
            // Console.WriteLine("------------");0
            //
            // for (var i = 0; i < 20; i++)
            // {
            //     Console.WriteLine("" + i + " <---> " + Convert.ToString(i, 2));
            // }


            // CountFrom0ToProperNumber(2);
            // CountFrom0ToProperNumber(3);
            // CountFrom0ToProperNumber(15);
            // CountFrom0ToProperNumber(16);

            Console.WriteLine(CountFrom0ToProperNumber(30));

            // Console.WriteLine(CountOnes(93960293923410, 153413882626292));
        }

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


