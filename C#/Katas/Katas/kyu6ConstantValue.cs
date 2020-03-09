using System.Linq;

namespace Katas
{
    public class kyu6ConstantValue
    {
        public static void Main(string[] args)
        {


        }

        public static int Solve(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            return s
                .Split(new[] {'a', 'e', 'i', 'o', 'u'})
                .Select(splitted => splitted.Sum(oneChar => oneChar - 'a' + 1))
                .Concat(new[] {0}).Max();
        }
    }
}