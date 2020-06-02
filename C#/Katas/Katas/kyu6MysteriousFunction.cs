using System.Linq;

namespace Katas
{
    public class kyu6MysteriousFunction
    {
        public static int GetNum(long num)
        {
            var numbers = new[] {'0', '6', '9'};
            return
                num.ToString()
                    .Count(c => c == '8') * 2
                + num.ToString()
                    .Count(c => numbers.Contains(c));
        }
    }
}