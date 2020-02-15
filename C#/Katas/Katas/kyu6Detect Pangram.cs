using System.Linq;

namespace Katas
{
    public class kyu6Detect_Pangram
    {
        public static bool IsPangram(string str)
        {
            return str.Where(char.IsLetter).Select(char.ToLower).ToHashSet().Count == 26;
        }
    }
}