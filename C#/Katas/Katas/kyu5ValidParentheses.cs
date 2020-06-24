using System.Linq;

namespace Katas
{
    public class kyu5ValidParentheses
    {
        public static bool ValidParentheses(string input)
        {
            input = string.Join("", input.Where(c => c == '(' || c == ')'));
            var l = 0;
            while (l != input.Length)
            {
                l = input.Length;
                input = input.Replace("()", "");
            }
            return input.Length == 0;
        }
    }
}