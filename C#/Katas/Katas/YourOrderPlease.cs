using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class YourOrderPlease
    {
        public static string Order(string words)
        {
            var sortedList = new SortedList<string, string>();
            string[] splited = words.Split(" ");
            string[] splitedNumber = splited
                .Select(w => Regex.Match(w, "\\d").Value)
                .ToArray();

            for (int i = 0; i < splited.Length; i++)
            {
                sortedList.Add(splitedNumber[i], splited[i]);
            }

            StringBuilder answer = new StringBuilder();
            foreach (var item in sortedList)
            {
                answer.Append(item.Value + " ");
            }

            return answer.ToString().Trim();
        }
    }
}