using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6BackwardsReadPrimes
    {


        public static string backwardsPrime(long start, long end)
        {
            var answer = new StringBuilder();
            for (var i = start; i <= end; i++)
            {
                if (!IsPalindrome(i) && IsPrime(i) && IsPrime(long.Parse(string.Join("",i.ToString().Reverse()))))
                {
                    answer.Append(i + " ");
                }
            }
            return answer.ToString().Trim();
        }

        private static bool IsPrime(long number)
        {
            if ((number & 1) == 0) return number == 2;
            for (var i = 3; (i * i) <= number; i += 2) if (number % i == 0) return false;
            return number != 1;
        }

        private static bool IsPalindrome(long number)
        {
            return number.ToString() == string.Join("", number.ToString().Reverse());
        }


    }
}