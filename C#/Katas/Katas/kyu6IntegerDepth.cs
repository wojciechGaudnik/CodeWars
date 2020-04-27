using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6IntegerDepth
    {
        public static int ComputeDepth(int n)
        {
            var set = new HashSet<char>();
            for (var i = 1;; i++)
            {
                set.UnionWith((n * i).ToString().ToHashSet());
                if (set.Count == 10) return i;
            }
        }
    }
}