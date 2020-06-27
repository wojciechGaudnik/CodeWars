using System.Linq;

namespace Katas
{
    public class kyu5GreedIsGood
    {
        public static int Score(int[] dice)
        {
            return dice
                    .Select(n => (n == 1) ? 10 : n)
                    .GroupBy(n => n)
                    .Select(n =>
                        (n.Key == 10 || n.Key == 5) ? ((n.Count() / 3) * 100 * n.Key) + (n.Count() % 3) * 10 * n.Key :
                        (n.Count() >= 3) ? n.Key * 100 : 0).Sum();
        }
    }
}