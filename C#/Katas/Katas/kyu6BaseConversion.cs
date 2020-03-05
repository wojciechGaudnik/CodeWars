using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6BaseConversion
    {
        public string Convert(string input, string source, string target)
        {
            return ToBaseX(ToBaseTen(input, source), target);
        }

        public static double ToBaseTen(string number, string source)
        {
            var convertDictionary = source
                .Select((c, i) => new {c, i})
                .ToDictionary(x => x.c, x => x.i);

            return string.Join("", number.Reverse())
                .Select((t, i) => convertDictionary[t] *  Math.Pow(source.Length, i))
                .Sum();
        }

        public static string ToBaseX(double number, string target)
        {
            if(number == 0) return target[0].ToString();
            var answerList = new List<double>();
            while (number > 0)
            {
                answerList.Add(number % target.Length);
                number = Math.Floor(number / target.Length);
            }
            answerList.Reverse();
            return string
                .Join("", answerList
                    .Select(e => target[(int) e])
                    .ToArray());
        }
    }

    public class Alphabet
    {
        public const string BINARY = "01";
        public const string OCTAL = "01234567";
        public const string DECIMAL = "0123456789";
        public const string HEXA_DECIMAL = "0123456789abcdef";
        public const string ALPHA_LOWER = "abcdefghijklmnopqrstuvwxyz";
        public const string ALPHA_UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string ALPHA = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string ALPHA_NUMERIC = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    }
}