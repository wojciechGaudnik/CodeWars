using System.Collections;

namespace Katas
{
    public class FoldAnArray
    {
        public static int[] FoldArray(int[] array, int runs)
        {
            ArrayList answer = new ArrayList();
            answer.AddRange(array);

            while (runs-- > 0)
            {
                int length = answer.Count / 2;
                for (int i = 0; i < length; i++)
                {
                    answer[i] = (int)answer[i] + (int)answer[answer.Count - 1];
                    answer.RemoveAt(answer.Count - 1);
                }
            }
            int[] outAnswer = new int[answer.Count];
            int j = 0;
            foreach (int n in answer)
            {
                outAnswer[j++] = n;
            }
            return outAnswer;
        }
    }
}