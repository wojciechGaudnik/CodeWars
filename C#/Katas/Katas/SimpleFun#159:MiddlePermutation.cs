using System;

namespace Katas
{
    public class SimpleFun_159_MiddlePermutation
    {
        public static void Main(string[] args)
        {
        }

        public string MiddlePermutation(string s)
        {
            var sortedStringArray = s.ToCharArray();
            Array.Sort(sortedStringArray);
            var sortedString = string.Join("", sortedStringArray);
            var middle = 0;
            string reminder;
            if (sortedString.Length % 2 == 0)
            {
                middle = (sortedString.Length / 2) - 1;
                reminder = sortedString.Substring(0, middle) + sortedString.Substring(middle + 1);
                return (sortedString[middle] + Reverse(reminder));
            }

            middle = sortedString.Length / 2;
            reminder = sortedString.Substring(0, middle - 1) + sortedString.Substring(middle + 1);
            return (sortedString[middle] + sortedString[middle - 1].ToString() + Reverse(reminder));
        }

        private static string Reverse(string stringIn)
        {
            var charArray = stringIn.ToCharArray();
            Array.Reverse(charArray);
            return string.Join("", charArray);
        }
    }
}