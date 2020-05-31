namespace Katas
{
    public class kyu4SimpleFun119SubSetsParity
    {
        public string SubsetsParity(int n, int k)
        {
            if (n == k) return "ODD";
            if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            while (k != 0)
            {
                k /= 2;
                n /= 2;
                if (n % 2 == 0 && k % 2 == 1) return "EVEN";
            }
            return "ODD";
        }
    }
}