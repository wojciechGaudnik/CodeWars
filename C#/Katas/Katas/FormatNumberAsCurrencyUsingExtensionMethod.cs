using System;

namespace Katas
{
    public static class FormatNumberAsCurrencyUsingExtensionMethod
    {
        static void Main(string[] args)
        {
//            Console.WriteLine(1m.ToCurrency("$"));
            Console.WriteLine((-12345.68m).ToCurrency("$"));
        }

        public static string ToCurrency(this decimal dDecimal, string format)
        {
            return ((dDecimal < 0) ? "-" : "")
                   + $"{format}"
                   + $"{Math.Abs(decimal.Round(dDecimal, 2)):0.00}";
        }
    }
}