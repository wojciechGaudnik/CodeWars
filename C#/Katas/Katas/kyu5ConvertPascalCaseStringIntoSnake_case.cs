using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu5ConvertPascalCaseStringIntoSnake_case
    {
        public static string ToUnderscore(int str) => Convert.ToString(str);
        public static string ToUnderscore(string str) =>
            string.Join("",
                str.Select(c => (char.IsUpper(c)) ? "_" + char.ToLower(c) : "" + c)).Trim('_');


        public static string ToUnderscore1(string str)
        {
            var answer = new StringBuilder();
            foreach (var one in str)
            {
                if (char.IsUpper(one))
                {
                    answer.Append('_').Append(char.ToLower(one));
                    continue;
                }
                answer.Append(one);
            }
            return answer.ToString().Trim('_');
        }


    }
}