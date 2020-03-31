using System.Collections.Generic;

namespace Katas
{
    public class kyu6WhatCenturyIsIt
    {
        public static string WhatCentury(string year)
        {
            var ends = new Dictionary<char, string> {{'1', "st"}, {'2', "nd"}, {'3', "rd"}};
            var intYear = int.Parse(year);
            var answer = (intYear % 100 != 0)? intYear / 100 + 1:intYear / 100;
            var last = answer.ToString()[answer.ToString().Length - 1];
            return answer + ((answer % 100 > 20 || answer % 100 < 10)?((ends.ContainsKey(last))? ends[last]: "th"):"th");
        }

    }
}