using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6SimpleFun23SquareDigitsSequence
    {
        public static void Main(string[] args)
        {
            var test = new kyu6SimpleFun23SquareDigitsSequence();
            Console.WriteLine(test.SquareDigitsSequence(16));
            Console.WriteLine(test.SquareDigitsSequence(103));
            Console.WriteLine(test.SquareDigitsSequence(1));
        }

        public int SquareDigitsSequence(int a0){
            var number = a0;
            var count = 0;
            var set = new HashSet<int>();
            set.Add(a0);

            while (true)
            {
                var buff = Next(number);
                if (set.Contains(buff)) break;
                set.Add(buff);
                number = buff;
            }

            return set.Count + 1;

        }

        private int Next(int number)
        {
            return (int) number.ToString().Select(c => Math.Pow(int.Parse(c.ToString()), 2)).Sum();
        }

    }
}