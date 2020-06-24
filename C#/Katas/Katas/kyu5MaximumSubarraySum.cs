using System;
using System.Linq;

namespace Katas
{
    public class kyu5MaximumSubarraySum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MaxSequence(new []{1, 2 ,3, - 1}));
            Console.WriteLine(MaxSequence(new []{-2, 1, -3, 4, -1, 2, 1, -5, 4}));
            Console.WriteLine(MaxSequence(new []{-14, 9, 35, 22, -33, 2, -4, -12, -33, 12, 12, 11, 8, -34, -30, -26, 32, -13, -28, -30, -19, -7, -25, 30, 6, 29, -36, -2, -25, 18, 21, 1, 35, -38, 8, 23, -12, 3, 5, 11, 5, -28, -39, -34, -25, -15, 1, 33, 23, 36}));
        }

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