using System.Linq;

namespace Katas
{
    public class kyu6Plus1Array
    {
        public static int[] UpArray(int[] num)
        {
            if(num.Length == 0 || num.Any(i => i < 0 || i > 9)) return null;
            var isLastNine = num[0] == 9;
            for (var i = num.Length - 1; i >= 0; i--)
            {
                if (num[i] == 9)
                {
                    num[i] = 0;
                    continue;
                }
                num[i]++;
                break;
            }
            if (!isLastNine) return num;
            if (num[0] != 0) return num;
            var one = new[] {1};
            return one.Concat(num).ToArray();
        }
    }
}