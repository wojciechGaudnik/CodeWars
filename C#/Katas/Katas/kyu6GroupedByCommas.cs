using System;
using System.Linq;

namespace Katas
{
    public class kyu6GroupedByCommas
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GroupByCommas(1000000000));
        }

        public static string GroupByCommas(int n)
        {
            var answer = string.Join("", n.ToString().Reverse());
            for (var i = 3; i < answer.Length; i += 4)
            {
                answer = answer.Insert(i, ",");
            }
            return string.Join("",  answer.Reverse());
        }
    }
}