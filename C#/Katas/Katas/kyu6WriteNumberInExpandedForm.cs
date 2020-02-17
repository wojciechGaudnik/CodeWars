using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6WriteNumberInExpandedForm
    {
        public static string ExpandedForm(long num)
        {
            var answer = new StringBuilder();
            for (int i = 0, r = num.ToString().Length - 1; i < num.ToString().Length; i++, r--)
            {
                if (num.ToString()[i] == '0') continue;
                answer.Append(Convert.ToInt32(num.ToString()[i].ToString()) + "" + Math.Pow(10, r).ToString().Substring(1));
                answer.Append(" + ");
            }
            return Regex.Replace(answer.ToString(), "(\\s\\+\\s)\\Z", "");
        }

    }
}