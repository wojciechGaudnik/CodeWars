using System;
using System.Numerics;
using System.Text;

namespace Katas
{
    public class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            if (a == "") a = "0";
            if (b == "") a = "0";
            BigInteger A = BigInteger.Parse(a);
            BigInteger B = BigInteger.Parse(b);
            return (A + B).ToString();
        }

        public static string Add2(string a, string b)
        {
            if (a.Length > b.Length)
            {
                b = b.Insert(0, new string('0', a.Length - b.Length));
            }
            else if (b.Length > a.Length)
            {
                a = a.Insert(0, new string('0', b.Length - a.Length));
            }

            var reminder = 0;
            var answer = new StringBuilder();
            for (var i = a.Length - 1; i >= 0; i--)
            {
                answer.Append(((Convert.ToInt16(a[i].ToString()) + Convert.ToInt16(b[i].ToString())) + reminder) % 10);
                reminder = (((Convert.ToInt16(a[i].ToString()) + Convert.ToInt16(b[i].ToString())) + reminder) / 10);
            }
            if(reminder != 0) answer.Append(reminder);
            var chars = answer.ToString().ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
    }
}