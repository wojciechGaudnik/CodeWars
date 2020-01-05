using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class FindTheUnknownDigit
    {
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