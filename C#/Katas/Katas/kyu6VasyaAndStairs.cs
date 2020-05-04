namespace Katas
{
    public class kyu6VasyaAndStairs
    {
        public static int NumberOfSteps(int n, int m)
        {
            var rest = 0;
            var minSteps = n / 2 + (n % 2);
            while ((minSteps + rest) % m != 0 && n > 0)
            {
                rest++;
                n--;
                minSteps = n / 2 + (n % 2);
            }
            if (n <= 0) return -1;
            return minSteps + rest;
        }


    }
}