using System;
using System.Linq;

namespace Katas
{
    public class kyu6DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (ants == null) return 0;
            var dead = ants.Replace("ant" ,"");
            var parts = dead.ToArray()
                .Where(char.IsLetter)
                .GroupBy(c => c)
                .Select(group => new {sign = group.Key, size = group.Count()}).ToArray();
            var a = parts.Where(group => group.sign == 'a').Select(group => group.size).FirstOrDefault(number => number > 0);
            var n = parts.Where(group => group.sign == 'n').Select(group => group.size).FirstOrDefault(number => number > 0);
            var t = parts.Where(group => group.sign == 't').Select(group => group.size).FirstOrDefault(number => number > 0);
            var max = Math.Max(a, n);
            max = Math.Max(max, t);
            return max;
        }

    }
}