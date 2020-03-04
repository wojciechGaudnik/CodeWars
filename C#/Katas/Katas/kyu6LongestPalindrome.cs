using System.Linq;

namespace Katas
{
    public class kyu6LongestPalindrome
    {
        public static int GetLongestPalindrome(string str)
        {
            if (string.IsNullOrEmpty(str)) return 0;
            var max = str.Length + 1;
            while (max-- > 0)
            {
                for (var i = 0; i + max <= str.Length; i++)
                {
                    if (IsPalindrome(str.Substring(i, max)))
                    {
                        return max;
                    }
                }
            }
            return 0;
        }

        private static bool IsPalindrome(string str)
        {
            return str == string.Join("", str.Reverse());
        }
    }
}