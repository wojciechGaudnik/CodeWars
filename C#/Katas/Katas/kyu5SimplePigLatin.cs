using System.Linq;

namespace Katas
{
    public class kyu5SimplePigLatin
    {
        public static string PigIt(string str)
        {
            return string.Join(" ",
                str.Split(" ")
                    .Select(s => s.Substring(1, s.Length - 1) + s[0] + "ay")
                    .ToArray());
        }
    }
}