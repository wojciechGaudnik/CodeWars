using System;
using System.Linq;

namespace Katas
{
    public class kyu6AreWeAlternate
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsAlt("amazon"));
            Console.WriteLine(IsAlt("cicab"));
            Console.WriteLine(IsAlt("jeiac"));
        }

        public static bool IsAlt(string word)
        {
            var vowels = new []{'a', 'e', 'i', 'o', 'u'};
            var start = vowels.Contains(word[0]) ? 0 : 1;
            for (var i = start; i < word.Length; i += 2)
            {
                if(!vowels.Contains(word[i])) return false;
            }
            for (var i = start + 1; i < word.Length; i += 2)
            {
                if(vowels.Contains(word[i])) return false;
            }
            return true;
        }


    }
}