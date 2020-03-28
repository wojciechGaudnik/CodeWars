namespace Katas
{
    public class FindIfContains
    {
        public static bool isArrayInAnother(int[] bigArray, int[] smallerArray)
        {
            for (var i = 0; i < bigArray.Length; i++)
            {
                var iBuff = i;
                for (var j = 0; j < smallerArray.Length; j++, iBuff++)
                {
                    if (bigArray[iBuff] != smallerArray[j])
                    {
                        break;
                    }
                    if(j == smallerArray.Length - 1) return true;
                }
            }
            return false;
        }
    }
}