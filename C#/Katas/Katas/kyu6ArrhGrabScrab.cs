using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6ArrhGrabScrab
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",
                Grabscrab("ortsp", new List<string> {"sport", "parrot", "ports", "matey"})));

        }

        public static List<string> Grabscrab(string anagram, List<string> dictionary)
        {
            var sortedAnagram = sortString(anagram);
            return dictionary.Where(s => s.Length == sortedAnagram.Length).Where(s => sortedAnagram.Equals(sortString(s))).ToList();
        }

        private static string sortString(string toSort)
        {
            var charArray = toSort.ToCharArray();
            Array.Sort(charArray);
            return string.Join("", charArray);
        }
    }
}