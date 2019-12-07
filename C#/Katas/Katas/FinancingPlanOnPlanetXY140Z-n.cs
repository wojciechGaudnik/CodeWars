namespace Katas
{
    public class FinancingPlanOnPlanetXY140Z_n
    {
        public static ulong finance(ulong n)
        {
            ulong answer = 0, last = 0, top = 1, bottom = 1;
            while (bottom <= n)
            {
                last += ++top + ++top -(++bottom);
                answer += last;
            }
            return answer;
        }
    }
}