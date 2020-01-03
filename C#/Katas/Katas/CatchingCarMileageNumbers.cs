using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class CatchingCarMileageNumbers
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number <= 97) return 0;
            var answer = 0;
            for (var i = (number < 100)? 100: number; i <= number + 2; i++)
            {
                if (i == number && Zeros(i)) return 2;
                if (Zeros(i)) answer = 1;
                if (i == number && IsTheSame(i)) return 2;
                if (IsTheSame(i)) answer = 1;
                if (i == number && InOrder(i)) return 2;
                if (InOrder(i)) answer = 1;
                if (i == number && IsPalindrome(i)) return 2;
                if (IsPalindrome(i)) answer = 1;
                if (i == number && IsAwesome(i, awesomePhrases)) return 2;
                if (IsAwesome(i, awesomePhrases)) answer = 1;
            }
            return answer;
        }

        private static bool Zeros(int number)
        {
            return Regex.Match(number.ToString(), "^(\\d)0+$").Success;
        }

        private static bool IsTheSame(int number)
        {
            return Regex.Match(number.ToString(), "^(\\d)\\1+$").Success;
        }

        private static bool InOrder(int number)
        {
            return Regex.Match(number.ToString(),
                "^(((?=01|12|23|34|45|56|67|78|89|90)\\d)+|((?= 09|98|87|76|65|4|43|32|21|10)\\d)+)\\d$").Success;
        }

        private static bool IsPalindrome(int number)
        {
            return int.Parse(string.Join("", number.ToString().Reverse())) == number;
        }

        private static bool IsAwesome(int number, List<int> awesome)
        {
            return awesome.Any(oneAwesome => number == oneAwesome);
        }
    }
}