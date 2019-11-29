using System;
using System.Text;

namespace Katas
{
    public class ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence
    {
        public static string Remove(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != '!')
                {
                    return s.Substring(0, i + 1);
                }
            }
            return s;
        }
    }
}