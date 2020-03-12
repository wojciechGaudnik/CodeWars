using System;
using System.Linq;

namespace Katas
{
    public class kyu6StatisticsForAnAthleticAssociation
    {
        public static void Main(string[] args)
        {

        }

        public static string stat(string strg)
        {
            if (strg == "") return "";
            var listTimeSpans = strg
                .Split(", ")
                .Select(e => new TimeSpan(
                    Convert.ToInt32(e.Split("|")[0]),
                    Convert.ToInt32(e.Split("|")[1]),
                    Convert.ToInt32(e.Split("|")[2])))
                .ToList();
            var range = listTimeSpans.Max() - listTimeSpans.Min();
            var average = new TimeSpan((long) listTimeSpans.Average(timeSpans => timeSpans.Ticks));
            TimeSpan median;
            listTimeSpans.Sort();
            if (listTimeSpans.Count % 2 == 1) median = listTimeSpans[listTimeSpans.Count / 2];
            else median = (listTimeSpans[listTimeSpans.Count / 2] + listTimeSpans[(listTimeSpans.Count / 2) - 1]) / 2;
            return string.Format($"Range: {range.Hours:00}|{range.Minutes:00}|{range.Seconds:00} " +
                                 $"Average: {average.Hours:00}|{average.Minutes:00}|{average.Seconds:00} " +
                                 $"Median: {median.Hours:00}|{median.Minutes:00}|{median.Seconds:00}");
        }

    }
}