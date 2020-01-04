using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class parseInReloaded
    {
        public static void Main(string[] args)
        {
        }

        public static int ParseInt(string s)
        {
            IDictionary<string, int> dictionarySingle = new Dictionary<string, int>()
            {
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 10},
                {"eleven", 11},
                {"twelve", 12},
                {"thirteen", 13},
                {"fourteen", 14},
                {"fifteen", 15},
                {"sixteen", 16},
                {"seventeen", 17},
                {"eighteen", 18},
                {"nineteen", 19},
                {"twenty", 20},
                {"thirty", 30},
                {"forty", 40},
                {"fifty", 50},
                {"sixty", 60},
                {"seventy", 70},
                {"eighty", 80},
                {"ninety", 90}
            };
            IDictionary<string, int> dictionaryMulti = new Dictionary<string, int>()
            {
                {"hundred", 100},
                {"thousand", 1000},
                {"million", 1000000}
            };

            int x = 0, y = 0;
            var numbersStrings = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var numberSting in numbersStrings)
            {
                if(dictionaryMulti.ContainsKey(numberSting))
                {
                    x *= dictionaryMulti[numberSting];
                    if (x < 1000) continue;
                    y = x;
                    x = 0;
                }
                else if (numberSting != "and")
                {
                    x += Convert(numberSting, dictionarySingle);
                }
            }
            return x + y;
        }

        private static int Convert(string number, IDictionary<string, int> dict)
        {
            var converted = number.Split("-");
            if (converted.Length > 1)
            {
                return dict[converted[0]] + dict[converted[1]];
            }
            return dict[converted[0]];
        }
    }
}