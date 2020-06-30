using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5BestTravel
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            var max = 0;
            foreach (var one in GetPermutations(ls, k))
            {
                var sum = one.Sum();
                if (sum == t) return t;
                if (sum > max && sum <= t) max = sum;
            }

            if (max == 0) return null;
            return max;
        }

        static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            var i = 1;
            var enumerable = items as T[] ?? items.ToArray();
            foreach (var item in enumerable)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(enumerable.Skip(i++), count - 1))
                        yield return new T[] { item }.Concat(result);
                }
            }
        }
    }
}