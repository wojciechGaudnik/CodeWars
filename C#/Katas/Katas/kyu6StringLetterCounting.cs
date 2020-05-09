using System.Linq;

namespace Katas
{
    public class kyu6StringLetterCounting
    {
        public static string StringLetterCount(string str)
        {
            return string.Join("", str
                .Where(char.IsLetter)
                .Select(char.ToLower)
                .GroupBy(c => c)
                .Select(group => new {sign = group.Key, size = group.Count()})
                .OrderBy(g => g.sign)
                .Select(g => string.Join("", g.size + g.sign.ToString())));
        }

    }
}