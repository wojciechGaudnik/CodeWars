namespace Katas
{
    public class kyu6CalculateNumberOfInversionsInArray
    {
        public static int CountInversions(int[] array)
        {
            var answer = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) answer++;
                }
            }
            return answer;
        }
    }
}