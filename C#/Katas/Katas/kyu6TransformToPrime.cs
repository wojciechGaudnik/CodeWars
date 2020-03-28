using System;
using System.Linq;

namespace Katas
{
    public class kyu6TransformToPrime
    {
        public static int MinimumNumber(int[] numbers)
        {
            var sum = numbers.Sum();
            var i = sum;
            while (!IsPrime(i++)){}
            return i - sum - 1;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 3; i <= boundary; i+=2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}