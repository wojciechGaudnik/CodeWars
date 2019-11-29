using System.Text.RegularExpressions;

namespace Katas
{
    public class validateCodeWithSimpleRegex
    {
        public static bool ValidateCode(string code)
        {
            return Regex.IsMatch(code, "^[1,2,3]");
        }
    }
}