using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{

    public class ReplaceWithAlphabetPosition
    {
        public static void Main(string[] args)
        {
            string words = "The sunset sets at twelve o' clock.";
            Console.WriteLine(AlphabetPosition(words));
            Console.WriteLine((int)'a' - 96);
        }

        public static string AlphabetPosition(string words)
        {
            return String.Join(" ", Regex.Replace(words, "[^A-Za-z]", "").ToLower().Select(c => (c - 96)));
        }

    }
}