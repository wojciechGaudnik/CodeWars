using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class MostFrequentlyUsedWordsInaText
    {
        public static List<string> Top3(string s)
        {
            Console.WriteLine(s);
            var words = Regex.Matches(s, "[a-zA-Z]+'*[a-zA-Z]*'*[a-zA-Z]*");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word.ToString().ToLower()))
                {
                    dictionary[word.ToString().ToLower()] += 1;
                }
                else
                {
                    dictionary[word.ToString().ToLower()] = 1;
                }
            }

            var listSorted = dictionary.ToList();
            listSorted.Sort((w1, w2) => (w1.Value == w2.Value)? (w1.Key.Length > w2.Key.Length)? 1: -1: (w1.Value < w2.Value) ? 1: -1);
            return listSorted.Select(pair => pair.Key).Take(3).ToList();
        }
    }
}