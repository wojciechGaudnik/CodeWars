using System.Linq;

namespace Katas
{
    public class kyu6ThrowingDarts
    {
        public static int ScoreThrows(double[] radiuses)
        {
            if (radiuses == null || radiuses.Length == 0) return 0;
            var score = radiuses.Count(r => r >= 5.0 && r <= 10.0) * 5;
            score += radiuses.Count(r => r < 5.0) * 10;
            score += (radiuses.Count(r => r < 5.0) == radiuses.Length)? 100: 0;
            return score;
        }
    }
}