using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{

    public class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string words)
        {
            return String.Join(" ", Regex.Replace(words, "[^A-Za-z]", "").ToLower().Select(c => (c - 96)));
        }

    }
}