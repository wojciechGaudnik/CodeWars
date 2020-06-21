using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6WordPatterns
    {
        public static bool WordPattern(string pattern, string str)
        {
            var dict = new Dictionary<char, string>();
            var spited = str.Split(" ");
            if (pattern.Length != spited.Length) return false;
            if (pattern.ToHashSet().Count != spited.ToHashSet().Count) return false;
            for (var i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]) && spited[i] != dict[pattern[i]]) return false;
                if (dict.ContainsKey(pattern[i]) && spited[i] == dict[pattern[i]]) continue;
                dict.Add(pattern[i], spited[i]);
            }
            return true;
        }

    }
}