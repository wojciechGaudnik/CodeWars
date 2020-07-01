using System.Collections.Generic;

namespace Katas
{
    public class kyu5JosephusPermutation
    {
        public static List<object> JosephusPermutation(List<object> items, int k)
        {
            if (k > items.Count) return JosephusPermutationBig(items, k);
            if (items.Count == 0) return items;
            var answer = new List<object>();
            var index = k - 1;
            while (items.Count > 1)
            {
                answer.Add(items[index]);
                items.RemoveAt(index);
                index = (index + k - 1) % items.Count;
            }
            answer.Add(items[0]);
            return answer;
        }

        private static List<object> JosephusPermutationBig(List<object> items, in int k)
        {
            var index = 0;
            var result = new List<object>();
            while(items.Count > 0){
                if(items.Count > 0){
                    index = IndexAdd(index, items.Count, k-1);
                }
                result.Add(items[index]);
                items.RemoveAt(index);
            }
            return result;
        }

        private static int IndexAdd(int index, int max, int increment)
        {
            for(var incrementI = 0; incrementI < increment; incrementI++){
                index++;
                if(index == max){
                    index = 0;
                } else if(index > max) {
                    index -= max;
                }
            }
            return max == 1 ? 0 : index;
        }
    }
}