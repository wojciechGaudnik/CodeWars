using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Katas
{
    public class kyu6ReversePolishNotationCalculator
    {
        public double evaluate(String expr)
        {
            if(string.IsNullOrEmpty(expr)) return 0.0;
            var inPut = expr.Split(" ").ToList();
            var stack = new Stack<double>();
            var dataTable = new DataTable();
            foreach (var one in inPut)
            {
                if (double.TryParse(one, out var operand))
                {
                    stack.Push(operand);
                    continue;
                }

                var first = stack.Pop();
                var second = stack.Pop();

                stack.Push(double
                    .Parse(dataTable
                        .Compute( second + one + first, "").ToString()));
            }
            return stack.Pop();
        }
    }
}