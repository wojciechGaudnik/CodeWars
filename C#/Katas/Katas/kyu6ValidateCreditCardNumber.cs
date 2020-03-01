using System;
using System.Linq;

namespace Katas
{
    public class kyu6ValidateCreditCardNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(test("1714"));
            Console.WriteLine("----");
            Console.WriteLine(test("12345"));
            Console.WriteLine("----");
            Console.WriteLine(test("891"));
        }

        public bool validate(string n)
        {
            return n
               .Reverse()
               .Where(c => c != ' ')
               .Select((c, i) => (i % 2 == 1) ? (c - '0') * 2 : (c - '0'))
               .Select(m => (m > 9)? m.ToString()[0] -'0' + m.ToString()[1] -'0':m)
               .Sum() % 10 == 0;
        }

        public static bool test(string str)
        {
            var test = str
                .Reverse()
                .Select((c, i) => (i % 2 == 1) ? (c - '0') * 2 : (c - '0'))
                .Select(n => (n > 9)? n.ToString()[0] -'0' + n.ToString()[1] -'0':n)
                .Sum() % 10 == 0;

            return test;

        }
    }
}