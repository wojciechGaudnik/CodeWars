namespace Katas
{
    public class kyu6StrongestEvenNumerInAnInterval
    {
        public static int strongestEven(int n, int m)
        {
            if(n == 1 && m == 2) return 2;
            long number = 1;
            long numberBuff = number;
            while (true)
            {
                numberBuff = number;
                while (numberBuff <= m)
                {
                    if (numberBuff >= n && numberBuff * 2 > m) return (int)numberBuff;
                    numberBuff *= 2;
                }
                number++;
            }
        }
    }
}