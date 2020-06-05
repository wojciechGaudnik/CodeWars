using System;

namespace Katas
{
    public class kyu6CountTheDays
    {
        public string countDays(DateTime d){
            var today = DateTime.Today;
            if(d.Subtract(today).Days < 0) return "The day is in the past!";
            if(d.Subtract(today).Days == 0) return "Today is the day!";
            return (d.Subtract(today).Days - 1) + " days";
        }
    }
}