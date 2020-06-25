using System;
using System.Linq;

namespace Katas
{
    public class kyu5MaximumSubarraySum
    {
        public static int MaxSequence(int[] arr)
        {
            Console.WriteLine("--->" + string.Join(", ", arr) + "<---");
            if (arr.Length == 0) return 0;
            if (arr.All(n => n >= 0)) return arr.Sum();
            if (arr.All(n => n < 0)) return 0;
            var answer = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j <= arr.Length; j++)
                {
                    var sum = arr.Take(j).Skip(i).Sum();
                    if ( sum > answer) answer = sum;
                }
            }
            return answer;
        }
    }
}