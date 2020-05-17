using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6MostFrequentWeekDays
    {
        public static string[] MostFrequentDays(int year)
        {
            var yearDateTime = new DateTime(year, 1, 1);
            var dayOfWeekDict = new Dictionary<DayOfWeek, int>
            {
                {DayOfWeek.Monday, 0},
                {DayOfWeek.Tuesday, 0},
                {DayOfWeek.Wednesday, 0},
                {DayOfWeek.Thursday, 0},
                {DayOfWeek.Friday, 0},
                {DayOfWeek.Saturday, 0},
                {DayOfWeek.Sunday, 0},
            };
            while (yearDateTime.Year == year)
            {
                dayOfWeekDict[yearDateTime.DayOfWeek]++;
                yearDateTime = yearDateTime.AddDays(1);
            }
            var max = dayOfWeekDict.Select(day => day.Value).Max();
            return dayOfWeekDict.Where(day => day.Value == max).Select(day => day.Key.ToString()).ToArray();
        }
    }
}