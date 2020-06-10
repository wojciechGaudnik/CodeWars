using System;

namespace Katas
{
    public class kyu6ReducingByRulesToGetTheResult
    {
        public static void Main(string[] args)
        {
            Func<double, double, double>[] rules = new Func<double, double, double>[] {
                (a, b) => a + b,
                (a, b) => a - b
            };
            Console.WriteLine(rules.Length);

            foreach (var one in rules)
            {
                Console.WriteLine(one);
            }

        }

        public static double ReduceByRules(double[] numbers, Func<double, double, double>[] rules)
        {
            var answer = numbers[0];
            var r = 0;
            for (var i = 1; i < numbers.Length; i++)
            {
                answer = rules[r++](answer, numbers[i]);
                if (r == rules.Length) r = 0;
            }
            return answer;
        }
    }
}