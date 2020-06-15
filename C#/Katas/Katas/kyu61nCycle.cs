namespace Katas
{
    public class kyu61nCycle
    {
        public static int Running(int n)
        {
            if (n % 2 == 0 || n % 5 == 0) return -1;
            var i = 1;
            var answer = 1;
            for (;; ++i)
            {
                answer = answer * 10 % n;
                if (answer == 1) return i;
            }
        }
    }
}