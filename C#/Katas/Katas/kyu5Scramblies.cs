using System.Text;

namespace Katas
{
    public class kyu5Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            var strB = new StringBuilder(str1);
            foreach (var s2 in str2)
            {
                var test = true;
                for (var i = 0; i < strB.Length; i++)
                {
                    if (strB[i] == s2)
                    {
                        strB.Remove(i, 1);
                        test = false;
                        break;
                    }
                }
                if (test) return false;
            }
            return true;
        }
    }
}