using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Katas
{
    public class kyu6Basics03StringsNumbersAndCalculation
    {
        public static void Main(string[] args)
        {
            var test = new kyu6Basics03StringsNumbersAndCalculation();
            Console.WriteLine(test.calculateString(";$%§fsdfsd235??df/sdfgf5gh.000kk0000"));
            Console.WriteLine(test.calculateString("sdfsd23454sdf*2342"));
            Console.WriteLine(test.calculateString("fsdfsd235???34.4554s4234df-sdfgf2g3h4j442"));
            Console.WriteLine(test.calculateString("fsdfsd234.4554s4234df+sf234442"));
        }

        public string calculateString(string calcIt)
        {
            var dataTable = new DataTable();
            var goodChars = new[] {'+', '-', '*', '/', '.'};
            var cleanString = string.Join("", calcIt.Where(c => char.IsDigit(c) || goodChars.Contains(c)).ToArray());
            var computed = decimal.Parse(dataTable.Compute(cleanString, "").ToString() ?? decimal.Zero.ToString(CultureInfo.CurrentCulture));
            return Math.Round(computed).ToString(CultureInfo.CurrentCulture);
        }
    }
}