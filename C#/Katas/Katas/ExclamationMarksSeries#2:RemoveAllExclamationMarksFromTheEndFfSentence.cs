using System;
using System.Text;

namespace Katas
{
    public class ExclamationMarksSeries_2_RemoveAllExclamationMarksFromTheEndFfSentence
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove("Hi!"));
            Console.WriteLine(Remove("!Hi!asd fasdf asdf Hi asdfasdfasdf"));
            Console.WriteLine(Remove("!!asd fasdf asdf  asdfasdfasdf"));
        }
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