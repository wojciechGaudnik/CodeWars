using System.Linq;

namespace Katas
{
    public static class FindTheOddInt
    {
        // return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
        public static int find_it(int[] seq)
        {
            foreach (var i in seq)
            {
                if (seq.Count(n => n == i) % 2 == 1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}