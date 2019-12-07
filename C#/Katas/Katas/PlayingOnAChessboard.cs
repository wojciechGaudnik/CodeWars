using System.Linq;

namespace Katas
{
    public class PlayingOnAChessboard
    {
        static void Main(string[] args)
        {
//            int[] test = {1,2,3,4,};
//            ref int x2 =ref test[0];
//            x2 = 10;
//            Console.WriteLine();
//            test.Select(x => x).ToList().ForEach(x => Console.Write(x + ", "));
//
//            var array = new int[] { 1, 2, 3, 4, 5 };
//            var length = array.Length / 2;
//            var folded = array.Take(length).Zip(array.Reverse().Take(length), (a, b) => a + b);

//            foreach (var i in SplitAndAdd(new int[]{32,45,43,23,54,23,54,34},0))
////            foreach (var i in SplitAndAdd(new int[] {4, 2, 5, 3, 2, 5, 7}, 2))
//            {
//                Console.WriteLine(i);
//            }

        }

        public static int[] SplitAndAdd2(int[] numbers, int n)
        {
            if (n < 1 || numbers.Length < 2) return numbers;
            var minLength = numbers.Length / 2;
            var resultingArr = numbers.Take(minLength).Prepend(0).Skip(1 - numbers.Length % 2)
                .Zip(numbers.Skip(minLength), (x,y) => x+y).ToArray();
            return SplitAndAdd2(resultingArr, n-1);
        }
    }
}