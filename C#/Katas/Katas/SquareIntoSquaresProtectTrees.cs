using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class SquareIntoSquaresProtectTrees
    {
        public string decompose(long n) {
    var decomposeArray = Resolve(n, n * n);
            if(decomposeArray == null) return null;
            decomposeArray.RemoveAt(decomposeArray.Count -1);
            var result = decomposeArray.Select(ele => ele.ToString()).ToList();
            return string.Join(" ", result);
        }

        private static List<long> Resolve(long n, long remain){
            if(remain == 0){
                var r = new List<long> {n};
                return r;
            }
            for(var i = n - 1 ; i > 0; i--){
                if ((remain - i * i) < 0) continue;
                var r = Resolve(i, (remain - i * i));
                if (r == null) continue;
                r.Add(n);
                return r;
            }
            return null;
        }
    }
}