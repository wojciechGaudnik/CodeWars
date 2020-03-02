using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6PascalsTriangle
    {
        public static List<int> PascalsTriangle(int n)
        {
            if(n == 1) return new List<int>{1};
            if(n == 2) return new List<int>{1, 1, 1};
            if(n == 3) return new List<int>{1, 1, 1, 1, 2, 1};

            List<int> answer = new List<int>{1, 1, 1, 1, 2, 1};
            List<int> partLast = new List<int>{1, 2, 1};
            List<int> partActual = new List<int>();

            for (var i = 4; i <= n; i++)
            {
                answer.Add(1);
                for (var j = 0; j < partLast.Count - 1; j++)
                {
                    partActual.Add(partLast[j] + partLast[j + 1]);
                }
                answer.AddRange(partActual);
                answer.Add(1);
                partLast = partActual.Select(e => e).ToList();
                partLast.Insert(0, 1);
                partLast.Add(1);
                partActual.Clear();
            }
            return answer;
        }
    }
}