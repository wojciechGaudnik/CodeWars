using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Basics01_ConvertAnyNumber_Double_ToFraction
    {
        public static string toFraction(double n)
        {
            if(Math.Abs(n % 1) < 0.000000001) return Convert.ToString(n, CultureInfo.InvariantCulture);
            var number = Convert.ToString(n, CultureInfo.CurrentCulture);
            var numberSpited = Regex.Split(number, "\\.");
            if(numberSpited[1].Length > 9) numberSpited[1] = numberSpited[1].Substring(0, 9);
            var whole = long.Parse(numberSpited[0]);
            var a = long.Parse(numberSpited[1]);
            var b = (long)Math.Pow(10, numberSpited[1].Length);
            var cf = new ArrayList();
            while (b != 0 && cf.Count < 100)
            {
                var f = a / b;
                cf.Add(f);
                a -= (f * b);
                var temp = a;
                a = b;
                b = temp;
            }

            long numerator = 0;
            long denominator = 0;
            for (var i = 1; i <= cf.Count; i++)
            {
                Fraction(cf.GetRange(0, i), out var numeratorActual, out var denominatorActual);
                if (numeratorActual > 2000 || denominatorActual > 2000)
                {
                    break;
                }
                numerator = numeratorActual;
                denominator = denominatorActual;
            }

            if (whole > 0)
            {
                return $"{(whole * denominator) + numerator}/{denominator}";
            }
            if (whole < 0)
            {
                return $"{(whole * denominator) - numerator}/{denominator}";
            }
            return (n < 0)?$"-{numerator}/{denominator}":$"{numerator}/{denominator}";
        }

        public static void Fraction(ArrayList cf, out long n, out long d)
        {
            n = 1;
            d = (long)cf[cf.Count - 1];
            for (var i = cf.Count - 2; i > 0; i--)
            {
                n += (long)cf[i] * d;
                var temp = n;
                n = d;
                d = temp;
            }
        }
    }
}