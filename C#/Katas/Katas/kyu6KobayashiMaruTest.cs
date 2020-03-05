using System;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6KobayashiMaruTest
    {
        public static int[] Shoot(List<warbird> warbirds)
        {
            Console.WriteLine(warbirds.Count);
            var max = warbirds.Count;
            if (max >= 3)
            {
                warbirds.RemoveRange(2, max - 2);
                max = warbirds.Count;

            }
            var answer = new List<int>();
            var answerCompleted = new List<int>();
            for (var i = max - 1; i >= 0; i--)
            {
                answer.Add(i);
            }

            for (var i = 0; i < 5; i++)
            {
                answerCompleted.AddRange(answer);
            }
            return answerCompleted.ToArray();
        }

        public class warbird
        {
        }
    }


}