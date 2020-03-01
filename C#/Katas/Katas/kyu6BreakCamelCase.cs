using System.Linq;

namespace Katas
{
    public class kyu6BreakCamelCase
    {
        public static string BreakCamelCase(string str)
        {
            return string.Join("", str.Select(c => (char.IsUpper(c)) ? " " + c : c + ""));
        }
    }
}