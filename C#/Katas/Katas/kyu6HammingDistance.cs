using System.Linq;

namespace Katas
{
    public class kyu6HammingDistance
    {

        public static int Distance(string a, string b)
        {
            return a.Where((c, i) => c != b[i]).Count();
        }
    }
}