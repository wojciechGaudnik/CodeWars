namespace Katas
{
    public class FindTheMissingLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] != array[i + 1] - 1)
                    return (char) (array[i] + 1);
            }
            return (char) (array[array.Length - 1] + 1);
        }
    }
}