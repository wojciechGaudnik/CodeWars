using System;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6OrdinalNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Ordinal(0, true));
        }

        public static string Ordinal(int number, bool brief = false)
        {
            Console.WriteLine(number + brief.ToString());
            if (number >= 1 && number <= 3) return ReturnFromDictionary(number, brief);
            number %= 100;
            if (number >= 4 && number <= 20) return "th";
            number %= 10;
            if (number >= 1 && number <= 3) return ReturnFromDictionary(number, brief);
            return "th";
        }

        private static string ReturnFromDictionary(int number, bool brief)
        {
            var dictionary = new Dictionary<int, string>() {{1, "st"}, {2, "nd"}, {3, "rd"},
            };
            return
                (brief && (number == 2 || number == 3))
                    ? dictionary[number][dictionary[number].Length - 1].ToString()
                    : dictionary[number];
        }
    }
}