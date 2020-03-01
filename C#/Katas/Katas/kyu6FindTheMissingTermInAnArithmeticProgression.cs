using System.Collections.Generic;

namespace Katas
{
    public class kyu6FindTheMissingTermInAnArithmeticProgression
    {
        public static int FindMissing(List<int> list)
        {
            var first = list[1] - list[0];
            var second = list[2] - list[1];
            var different = (first < second)? first: second;
            for (var i = 1; i < list.Count; i++)
            {
                if(list[i - 1] + different != list[i]) return list[i - 1] + different;
            }

            return 0;
        }
    }
}