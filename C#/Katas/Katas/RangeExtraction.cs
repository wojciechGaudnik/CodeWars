using System;
using System.Text;

namespace Katas
{
    public class RangeExtraction
    {
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