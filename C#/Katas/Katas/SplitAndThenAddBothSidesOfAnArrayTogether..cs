using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    public class SplitAndThenAddBothSidesOfAnArrayTogether_
    {
        public static int[] SplitAndAdd(int[] numbers, int n)
        {
            if(n == 0) return numbers;
            int length = numbers.Length / 2;
            bool isOdd = numbers.Length % 2 == 1;
            IEnumerable<int> folded = (isOdd)
                ? numbers.Take(length).Zip(numbers.Skip(length + 1), (a, b) => a + b)
                : numbers.Take(length).Zip(numbers.Skip(length), (a, b) => a + b);

            int[] whole = new int[0];
            if (isOdd)
            {
                int[] last = folded.ToArray();
                int[] first = {numbers[length]};
                whole = new int[last.Length + 1];
                first.CopyTo(whole, 0);
                last.CopyTo(whole, 1);
            }
            else
            {
                whole = folded.ToArray();
            }

            n--;
            if (n == 0)
            {
                return whole;
            }
            return SplitAndAdd(whole, n);

        }
    }
}