namespace Katas
{
    public class N_thFibonacci
    {
        public static int NthFib(int n)
        {
            var first = 0;
            var second = 1;
            if (n == 1) return 0;
            if (n == 2) return 1;
            for (var i = 2; i < n; i++)
            {
                var next = first + second;
                (first, second) = (second, next);
            }
            return second;
        }

    }
}