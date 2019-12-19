using System.Collections;
using System.Linq;

namespace Katas
{
    public class Array_diff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            IList list = new ArrayList();
            foreach (var i in a)
            {
                if (!b.Contains(i))
                {
                    list.Add(i);
                }
            }
            // return a.Where(n => !b.Contains(n)).ToArray();
            return list.Cast<int>().ToArray();
        }
    }
}