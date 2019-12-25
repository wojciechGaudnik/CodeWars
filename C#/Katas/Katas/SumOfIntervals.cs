using System.Linq;

namespace Katas
{
    public class SumOfIntervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            if (intervals.Length == 0) return 0;
            int[][] sortedArray = intervals.Select(a => new int[]{a.Item1, a.Item2}).OrderBy(a => a[0]).ToArray();
            const int begin = 0;
            const int end = 1;
            var answer = 0;
            var lastBegin = sortedArray[0][begin];
            var lastEnd = sortedArray[0][end];
            foreach (var single in sortedArray)
            {
                if (single[begin] <= lastEnd)
                {
                    if (single[end] > lastEnd)
                    {
                        lastEnd = single[end];
                    }
                }
                if(single[begin] > lastEnd)
                {
                    answer += lastEnd - lastBegin;
                    lastBegin = single[begin];
                    lastEnd = single[end];
                }
            }
            return answer + lastEnd - lastBegin;
        }
    }
}