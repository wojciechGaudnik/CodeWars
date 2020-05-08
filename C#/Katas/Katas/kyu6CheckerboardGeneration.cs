using System;
using System.Linq;

namespace Katas
{
    public class kyu6CheckerboardGeneration
    {
        public static string Checkerboard(int size)
        {
            if(size <= 0) return String.Empty;
            var firstLine = string.Join("",
                Enumerable.Range(0, size)
                    .Select(i => (i % 2 == 0) ? "[r]" : "[b]")
                    .ToArray()) + "\n";
            var secondLine = string.Join("",
                Enumerable.Range(0, size)
                    .Select(i => (i % 2 == 1) ? "[r]" : "[b]")
                    .ToArray()) + "\n";
            var answer = string.Join("",
                Enumerable.Range(0, size)
                    .Select(i => (i % 2 == 0) ? firstLine : secondLine)
                    .ToArray());
            return answer;
        }
    }
}