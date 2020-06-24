using System.Linq;

namespace Katas
{
    public class kyu5MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var answer = Enumerable.Repeat(0, arr.Length).ToArray();
            var i = 0;
            foreach (var number in arr) if (number != 0) answer[i++] = number;
            return answer;
        }

    }
}