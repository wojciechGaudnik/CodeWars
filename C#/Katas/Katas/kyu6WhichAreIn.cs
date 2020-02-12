using System.Linq;

namespace Katas
{
    public class kyu6WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            return array1
                .Where(s1 => array2
                    .Any(s2 => s2.Contains(s1)))
                .OrderBy(s => s)
                .ToArray();
        }
    }
}