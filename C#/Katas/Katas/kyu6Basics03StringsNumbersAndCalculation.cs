using System;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Katas
{
    public class kyu6Basics03StringsNumbersAndCalculation
    {
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