using System;
using System.Data;

namespace Katas
{
    public class kyu3Calculator
    {
        public double Evaluate(string expression)
        {
            var dataTable = new DataTable();
            return Math.Round(
                Convert.ToDouble(
                    dataTable.Compute(expression.Replace(" ", ""), " ")), 6);
        }
    }
}