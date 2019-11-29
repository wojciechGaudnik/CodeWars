using System.Linq;

namespace Katas
{
    public class SpeedCode_2_ArrayMadness
    {
        public static bool ArrayMadness(int[] a, int[] b)
        {
            return a.Sum(x => x * x) > b.Sum(x => x * x * x);
        }
    }
}