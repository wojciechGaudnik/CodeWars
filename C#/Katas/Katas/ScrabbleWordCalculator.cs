using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Katas
{
    public class ScrabbleWordCalculator
    {
        public static int CalculateScrabbleWord(string word)
        {
            if (word.Length == 0) return 0;
            Dictionary<char, int> dictionary = new Dictionary<char, int>()
            {
                {'a', 1}, {'b', 3}, {'c', 3}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2},
                {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 3}, {'n', 1},
                {'o', 1}, {'p', 3}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1},
                {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10}
            };
            int count = 0;
            MatchCollection matchCollection = Regex.Matches(word, "([a-z]{1}(\\^|\\*)*)|(\\(d\\)|\\(t\\))");
            foreach (Match match in matchCollection)
            {
                if(match.ToString().Length == 1) count += dictionary[match.ToString()[0]];
                else if(match.ToString()[match.ToString().Length - 1] == '*') count += (dictionary[match.ToString()[0]] * match.ToString().Length);
                else if (match.ToString() == "(d)") count *= 2;
                else if (match.ToString() == "(t)") count *= 3;
            }

            word = Regex.Replace(word, "\\*|\\^|\\(d\\)|\\(t\\)", "");
            if (word.Length == 7) count += 50;
            return count;
        }
    }
}