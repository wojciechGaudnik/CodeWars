namespace Katas
{
    public class kyu6SqrtApproximation
    {
        public static object SqrtApproximation(int n)
        {
            for(var k = 0;;k++)
            {
                if (k * k == n) return k;
                if((k+1) * (k+1) > n && k * k < n) return new [] {k, k + 1};
            }
        }
    }
}