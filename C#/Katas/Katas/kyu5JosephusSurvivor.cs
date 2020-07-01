namespace Katas
{
    public class kyu5JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            if (n == 1)
                return 1;
            return (JosSurvivor(n - 1, k) + k - 1) % n + 1;
        }
    }
}