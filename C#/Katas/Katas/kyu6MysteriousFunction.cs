using System;
using System.Linq;

namespace Katas
{
    public class kyu6MysteriousFunction
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetNum(300));
            Console.WriteLine(GetNum(90782));
            Console.WriteLine(GetNum(123321));
        }

        public static int GetNum(long num)
        {
            var numbers = new[] {'0', '6', '9'};
            return
                num.ToString()
                    .Count(c => c == '8') * 2
                + num.ToString()
                    .Count(c => numbers.Contains(c));
        }
    }
}