using System.Collections.Generic;

namespace Katas
{
    public class kyu6DeleteOccurrencesOfAnElementIfItOccursMoreThanNNimes
    {
        public static void Main(string[] args)
        {
            var expected = new int[] {1, 1, 3, 3, 7, 2, 2, 2};
            DeleteNth(new int[] {1, 1, 3, 3, 7, 2, 2, 2, 2}, 3);

        }

        public static int[] DeleteNth(int[] arr, int x) {
            List<int> answer = new List<int>();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var one in arr)
            {
                int sum = 0;
                if (dictionary.TryGetValue(one, out sum) && sum < x)
                {
                    answer.Add(one);
                    dictionary[one]++;
                }
                else if(sum < x)
                {
                    answer.Add(one);
                    dictionary.Add(one, 1);
                }
            }
            return answer.ToArray();
        }
    }
}