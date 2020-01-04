using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class FindTheUnknownDigit
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(solveExpression("1+1=?").Equals(2));
            Console.WriteLine(solveExpression("123*45?=5?088").Equals(6));
            Console.WriteLine(solveExpression("-5?*-1=5?").Equals(0));
            Console.WriteLine(solveExpression("19--45=5?").Equals(-1));
            Console.WriteLine(solveExpression("??*??=302?").Equals(5));
            Console.WriteLine(solveExpression("?*11=??").Equals(2));
            Console.WriteLine(solveExpression("??*1=??").Equals(2));
        }

        public static int solveExpression(string expression)
        {
            expression = expression.Replace("--", "+");
            var missingNumbers = Enumerable.Range(0, 10)
                .Where(n =>
                    !expression
                        .ToCharArray()
                        .Where(char.IsDigit)
                        .Distinct()
                        .Select(c => c - '0')
                        .Contains(n));


            DataTable dataTable = new DataTable();
            foreach (var missingNumber in missingNumbers)
            {
                var expresionToTest = expression.Replace("?", missingNumber.ToString());
                if(Regex.IsMatch(expresionToTest, "(\\D|\\Z)0{2,}(\\D|\\Z)")) continue;
                if((bool) dataTable.Compute(expresionToTest, "")) return missingNumber;
            }
            return -1;
        }
    }
}