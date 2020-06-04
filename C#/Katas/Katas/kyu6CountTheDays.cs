using System;

namespace Katas
{
    public class kyu6CountTheDays
    {
        public static void Main(string[] args)
        {
            var test = new kyu6CountTheDays();
            Console.WriteLine(test.countDays(new DateTime(2020,6,5)));
        }

        public string countDays(DateTime d){
            var today = DateTime.Today;
            if(d.Subtract(today).Days < 0) return "The day is in the past!";
            if(d.Subtract(today).Days == 0) return "Today is the day!";
            return (d.Subtract(today).Days - 1) + " days";
        }
    }
}