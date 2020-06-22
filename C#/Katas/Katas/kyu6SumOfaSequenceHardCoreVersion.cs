using System;
using System.Numerics;

namespace Katas
{
    public class kyu6SumOfaSequenceHardCoreVersion
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(SumMy(1, 7, 3));
            // Console.WriteLine(SequenceSum(1, 7, 3));
            // Console.WriteLine(SequenceSum(780, 68515438, 5));
            // Console.WriteLine(SequenceSum(-2, 4, 658));
            Console.WriteLine(SequenceSum(97912879, -432, -1));
            Console.WriteLine(4793465985897232);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(double.MaxValue);


            // --->21 592683 -1<---
            // --->-368 86058849 -1<---
            // --->95780629 84 -1<---
            // --->-549459 4 -1<---
            // --->1322881 -570062 -1<---
            // --->5 64722 -1<---
            // --->-967 94895 -1<---
            // --->-120 -26 -1<---
            // --->-7 -44 -1<---
            // --->33 -11350 -1<---
            // --->-1202 3185113 -1<---
            // --->97912879 -432 -1<--- <--- źle liczy !!!




        }

        public static long SequenceSum(long start, long end, long step)
        {
            Console.WriteLine("--->" + start + " " + end + " " + step + "<---") ;
            if (start == end) return 0;
            if (start > 0 && end >= 0 && step > 0 && start > end) return 0;
            if (start < 0 && end <= 0 && step < 0 && start < end) return 0;
            if (start >= 0 && end < 0 && step > 0) return 0;
            if (start <= 0 && end > 0 && step < 0) return 0;
            if (start < 0 && end < 0 && step > 0 && start > end) return 0;
            if (start > 0 && end > 0 && step < 0 && start < end) return 0;
            if (start < 0 && end < 0 & step < 0)
            {
                start = Math.Abs(start);
                end = Math.Abs(end);
                step = Math.Abs(step);
                return -SequenceSumBetter(start, end, step);
            }
            return SequenceSumBetter(start, end, step);
        }

        private static long SequenceSumBetter(long start, long end, long step)
        {
            var numberOfNumbers = ((end - start) / step);
            // var allSteps = (Math.Pow(numberOfNumbers, 2) + numberOfNumbers) / 2;  //todo <--- good !
            var allSteps = (BigInteger.Pow(new BigInteger(numberOfNumbers), 2) + numberOfNumbers) / 2;
            // var allSteps = (numberOfNumbers / 2) * ( numberOfNumbers + 1);
            Console.WriteLine(((numberOfNumbers * start) + step * allSteps) + start);
            return (long) ((numberOfNumbers * start) + step * allSteps) + start;
        }

        private static long SumMy(long start, long end, long step)
        {
            if (start > end) return 0;
            long sum = 0;
            for (var i = start; i <= end; i += step) sum += i;
            return sum;
        }
    }
}