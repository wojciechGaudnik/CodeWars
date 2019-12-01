namespace Katas
{
    public class Banzai
    {
        public static int[] Amidakuji(string[] ar)
        {
            int[] answer = new int[ar[0].Length + 1];
            for (int i = 0; i < ar.Length; i++)ar[i] = "0" + ar[i] + "0";

            for (int i = 0; i < answer.Length; i++)
            {
                int position = i + 1;
                for (int j = 0; j < ar.Length; j++)
                {
                    if (ar[j][position - 1] == '1')
                    {
                        position--;
                        continue;
                    }
                    if (ar[j][position] == '1')position++;
                }
                answer[position-1] = i;
            }
            return answer;
        }
    }
}