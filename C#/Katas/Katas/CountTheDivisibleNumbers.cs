namespace Katas
{
    public class CountTheDivisibleNumbers
    {
        public static long DivisibleCount(long x, long y, long k)
        {
            return (x % k == 0)?(y / k) - (x / k) + 1:(y / k) - (x / k);
        }
    }
}