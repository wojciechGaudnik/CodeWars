using System.Collections.Generic;

namespace Katas
{
    public class kyu6MutalRecursion
    {
        private static Dictionary<int, int> FCache = new Dictionary<int, int>{{0 ,1}};
        private static Dictionary<int, int> MCache = new Dictionary<int, int>{{0 ,0}};

        public static int F(int n)
        {
            if(FCache.ContainsKey(n)) return FCache[n];
            FCache.Add(n, n - M(F(n - 1)));
            return FCache[n];
        }

        public static int M(int n)
        {
            if(MCache.ContainsKey(n)) return MCache[n];
            MCache.Add(n, n - F(M(n - 1)));
            return MCache[n];
        }
    }
}