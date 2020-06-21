using System;
using System.Linq;

namespace Katas
{
    public class kyu6SumOfaSequenceHardCoreVersion
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(SequenceSum(780, 68515438, 5));
            // Console.WriteLine(SequenceSum(3, 13, 4));
            // Console.WriteLine(SumMy(3, 13, 4));
            // Console.WriteLine(SumMy(3, 13, 2));
            // long partSum = Enumerable.Range(1, 13702931).Sum();
            // Console.WriteLine(partSum);
            // var start = 780;
            // var end = 68515438;
            // var step = 5;
            var start = 1;
            var end = 8;
            var step = 3;
            var numberStepsBetween = (end / step) - (start / step);
            var sumStarts = start * numberStepsBetween;
            var sumNumberOfSteps = (numberStepsBetween / 2) * (numberStepsBetween + 1);
            var sumSteps = sumNumberOfSteps * step;
            Console.WriteLine(sumSteps + sumStarts);



        }

        public static long SequenceSum(long start, long end, long step)
        {
            if ((end - start) + Math.Abs(step) < end - start) return 0;
            if (start < 0 && end < 0 & step < 0)
            {
                start = Math.Abs(start);
                end = Math.Abs(end);
                step = Math.Abs(step);
                return -SumMyBetter(start, end, step);
            }
            return SumMyBetter(start, end, step);
        }

        private static long SumMy(long start, long end, long step)
        {
            if (start > end) return 0;
            long sum = 0;
            for (var i = start; i <= end; i += step) sum += i;
            return sum;
        }

        private static long SumMyBetter(long start, long end, long step)
        {
            long sum = 0;
            if (start % step != 0) sum += start;
            if (end % step != 0) sum += end;
            var part = (int) ((end / step) - (start / step));
            var partSum = Enumerable.Range(1, part).Sum();

            return (sum + part * step) + part * start;
        }
    }
}