using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6CharacterWithLongestConsecutiveRepetition
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            Console.WriteLine(input);
            char? sign = null;
            var max = 0;
            var indexMax = input.Length;
            var setAdd = new HashSet<char>{'\\', '[', '*', ')', '(', '?', '+', '.'};
            var set = input.ToHashSet();
            foreach (var letter in set)
            {
                var pattern = "(" + letter + ")+";
                if(setAdd.Contains(letter)) pattern = "(\\" + letter + ")+";
                var regex = new Regex(pattern);
                foreach (var match in regex.Matches(input))
                {
                    Console.WriteLine(match.ToString());
                    if (match.ToString()?.Length > max)
                    {
                        indexMax = input.IndexOf(match.ToString());
                        sign = letter;
                        max = match.ToString().Length;
                    }

                    if (match.ToString()?.Length == max)
                    {
                        if (input?.IndexOf(match.ToString()) < indexMax)
                        {
                            indexMax = input.IndexOf(match.ToString());
                            sign = letter;
                            max = match.ToString().Length;
                        }
                    }
                }
            }
            return new Tuple<char?, int>(sign, max);
        }
    }
}