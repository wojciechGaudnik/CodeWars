using System;
using System.Linq;

namespace Katas
{
    public class HowManyNumbers3
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(string.Join("-", ));
            // FindAll(10, 3);
            Console.WriteLine("-------------------");
            // Console.WriteLine(string.Join("-", ));
            // Console.WriteLine(string.Join("-", FindAll(35, 6)));
            FindAll(27, 3);
            FindAll(35, 6);
            // Console.WriteLine(EvalObject());
        }


        public static int[] FindAll(int sum, int n)
        {
            var answer = Enumerable.Repeat(1, n).ToArray();
            answer[n - 1] = sum - n + 1;
            var count = 0;


            var isPossible = true;
            var toMove = 0;
            for (var i = n - 1; i >= 0; i--)
            {
                if (answer[i] > 9 && toMove == 0)
                {
                    toMove = answer[i] - 9;
                    answer[i] = 9;
                    if (toMove == 0) break;
                    continue;
                }
                if (toMove == 0) break;
                if (toMove > 9)
                {
                    answer[i] = 9;
                    toMove -= 8;
                    continue;
                }
                if (toMove >= 9) continue;
                answer[i] += toMove;
                toMove = 0;
                break;
            }
            var min = answer.ToArray();



            var max = answer.ToArray();
            var lastIndexMinus = -1;
            while (isPossible)
            {
                isPossible = false;
                for (var i = n - 1; i > 0; i--)
                {
                    if (toMove == 0 && answer[i] > answer[i - 1])
                    {
                        answer[i]--;
                        toMove++;
                        isPossible = true;
                        lastIndexMinus = i;
                    }
                    if (toMove == 1 && answer[i - 1] + 1 <= answer[i])
                    {
                        answer[i - 1]++;
                        toMove--;
                        isPossible = true;
                        break;
                    }
                }
                if(toMove > 0) break;
            }
            if(lastIndexMinus >= 0) answer[lastIndexMinus]++;
            max = answer.ToArray();



            Console.WriteLine(string.Join(",", min));
            Console.WriteLine(string.Join(",", max));




            return new int[] {int.Parse(string.Join("", min)), int.Parse(string.Join("", max))};

        }


    }
}