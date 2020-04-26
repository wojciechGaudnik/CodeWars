using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6BingoCard
    {
        public static string[] GetCard()
        {
            var answer = new LinkedList<string>();
            var random = new Random();
            var step = 1;
            var size = new []{5, 5, 4, 5, 5};
            var zipped =
                "BINGO"
                    .ToArray()
                    .Zip(size, (c, i) => new {c, i})
                    .ToDictionary(item => item.c, item => item.i);
            foreach (var one in zipped)
            {
                for (int i = 0; i < one.Value; i++)
                {
                    var number = random.Next(step, step + 15);
                    if (answer
                        .Where(s => s.Contains(one.Key))
                        .Select(s => s.Substring(1, s.Length - 1))
                        .Select(int.Parse)
                        .ToArray()
                        .Contains(number))
                    {
                        i--;
                        continue;
                    }
                    answer.AddLast("" + one.Key + number);
                }
                step += 15;
            }

            return answer.ToArray();
        }


    }
}