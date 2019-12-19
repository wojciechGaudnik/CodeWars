using System.Linq;

namespace Katas
{
    public class TakeaTenMinuteWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            return walk.Count(x => x == "w") == walk.Count(x => x == "e") &&
                   walk.Count(x => x == "n") == walk.Count(x => x == "s") &&
                walk.Length == 10;
        }
    }
}