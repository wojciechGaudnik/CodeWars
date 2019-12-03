using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Hidden_Cubic_Numbers
    {
        public static String isSumOfCubes(String s)
        {
            StringBuilder answer = new StringBuilder();
            int totalSum = 0;
            MatchCollection stringNumbers = Regex.Matches(s, "(\\d{1,3})");
            foreach (Match stringNumber in stringNumbers)
            {
                int number = int.Parse(stringNumber.ToString());
                int sumNumber = 0;
                foreach (int i in stringNumber.ToString())
                {
                    sumNumber += (int)Math.Pow((i - 48), 3);
                }
                if (sumNumber == number)
                {
                    answer.Append(number + " ");
                    totalSum += sumNumber;
                }
            }
            if (answer.Length == 0)
            {
                return "Unlucky";
            }
            answer.Append(totalSum + " Lucky");
            return answer.ToString();
        }
    }
}