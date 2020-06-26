using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu5FirstNon_repeatingCharacter
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                var test = !s.Where((t, j) => i != j && char.ToLower(s[i]) == char.ToLower(t)).Any();
                if(test) return s[i].ToString();
            }
            return "";

        }
    }
}