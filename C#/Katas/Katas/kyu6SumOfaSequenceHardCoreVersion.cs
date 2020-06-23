using System;
using System.Numerics;

namespace Katas
{
    public class kyu6SumOfaSequenceHardCoreVersion
    {
        public static long SequenceSum(long start, long end, long step)
        {
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
            var allSteps = (BigInteger.Pow(new BigInteger(numberOfNumbers), 2) + numberOfNumbers) / 2;
            return (long) ((numberOfNumbers * start) + step * allSteps) + start;
        }
    }
}