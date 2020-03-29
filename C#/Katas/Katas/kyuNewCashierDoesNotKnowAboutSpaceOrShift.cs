using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class kyuNewCashierDoesNotKnowAboutSpaceOrShift
    {
        public static string GetOrder(string input)
        {
            var names = new LinkedList<string>();
            names.AddLast("Burger");
            names.AddLast("Fries");
            names.AddLast("Chicken");
            names.AddLast("Pizza");
            names.AddLast("Sandwich");
            names.AddLast("Onionrings");
            names.AddLast("Milkshake");
            names.AddLast("Milkshake");
            names.AddLast("Coke");

            var answer = new StringBuilder();
            foreach (var one in names)
            {
                while (input.Contains(one.ToLower()))
                {
                    answer.Append(one + " ");
                    input = input.Remove(input.IndexOf(one.ToLower(), StringComparison.Ordinal), one.Length - 1);
                }
            }
            return answer.ToString().Trim();
        }
    }
}