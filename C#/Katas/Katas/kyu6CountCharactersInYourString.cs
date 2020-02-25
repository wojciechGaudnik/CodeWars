using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6CountCharactersInYourString
    {
        public static Dictionary<char, int> Count(string str)
        {
            return str
                .Where(char.IsLetter)
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}