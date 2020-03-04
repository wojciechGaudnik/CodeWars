using System.Linq;

namespace Katas
{
    public class kyu6LengthOfMissingArray
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;
            if (arrayOfArrays.Any(e => e == null)) return 0;
            var lengthArrays = arrayOfArrays.Select(one => one.Length).OrderBy(e => e).ToList();
            if (lengthArrays.Any(e => e == 0)) return 0;
            var last = lengthArrays[0];
            for (var i = 1; i < lengthArrays.Count; i++)
            {
                if (last + 1 != lengthArrays[i]) return last + 1;
                last = lengthArrays[i];
            }
            return 0;
        }
    }
}