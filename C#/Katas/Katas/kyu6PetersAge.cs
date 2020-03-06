using System;

namespace Katas
{
    public class kyu6PetersAge
    {
        public static string HowOld(DateTime birthday)
        {
            var today = DateTime.Now;
            var years = today.Year - birthday.Year;
            var months = today.Month - birthday.Month;
            if (today.Day < birthday.Day) months--;
            if (months < 0)
            {
                years--;
                months += 12;
            }
            var day = (today - birthday.AddMonths((years * 12) + months)).Days;
            if (birthday.Month <= 2) day--;
            return string.Format($"Peter is {years} years, {months} months and {day} days old", years, months, day);
        }
    }
}