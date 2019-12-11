using System;

namespace Katas
{
    public static class FormatNumberAsCurrencyUsingExtensionMethod
    {
        public static string ToCurrency(this decimal dDecimal, string format)
        {
            return $"{((dDecimal < 0) ? "-" : "")}{format}{Math.Abs(decimal.Round(dDecimal, 2)):0.00}";
        }
    }
}