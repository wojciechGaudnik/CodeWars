using System;
using System.Text;

namespace Katas
{
    public class RangeExtraction
    {
        public static void Main(string[] args)
        {
            int[] test = {-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20};

            Console.WriteLine(Extract(test));
            Console.WriteLine("-6,-3-1,3-5,7-11,14,15,17-20 <-- good");
        }

        public static string Extract(int[] args)
        {
            StringBuilder answer = new StringBuilder();
            int start = int.MinValue;
            bool inRange = false;
            for (var i = 0; i < args.Length - 1; i++)
            {
                if (args[i] + 1 != args[i + 1] && !inRange)
                {
                    answer.Append(args[i] + ",");
                }
                else if (args[i] + 1 == args[i + 1] && !inRange)
                {
                    inRange = true;
                    start = args[i];
                }
                else if (args[i] + 1 != args[i + 1] && inRange)
                {
                    inRange = false;
                    if(start + 1 == args[i]) answer.Append(start + "," + args[i] + ",");
                    else answer.Append(start + "-" + args[i] + ",");
                }

            }
            if(inRange && start + 1 == args[args.Length - 1]) return answer.Append(start + "," + args[args.Length - 1]).ToString();
            if(inRange && start + 1 != args[args.Length - 1]) return answer.Append(start + "-" + args[args.Length - 1]).ToString();
            if(!inRange) return answer.Append(args[args.Length - 1]).ToString();
            return answer.ToString().Substring(0, answer.Length - 1);
        }
    }
}