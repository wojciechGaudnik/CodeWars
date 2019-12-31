using System;
using System.Collections.Generic;

namespace Katas
{
    public class HammingNumbers
    {
        private const double lb3 = 1.5849625007211561814537389439478;
        private const double lb5 = 2.3219280948873623478703194294894;
        private const double fctr = 6.0 * lb3 * lb5;
        private const double crctn = 2.4534452978042592646620291867186;
        private struct logrep {
            public readonly uint X2, X3, X5;
            public readonly double Lg;
            public logrep(uint x, uint y, uint z, double lg) {
                X2 = x;
                X3 = y;
                X5 = z;
                Lg = lg;
            }
        }

        public static long hamming(int n) {
            if (n < 2) return 1;
            var lgest = Math.Pow(fctr * n, 1.0/3.0) - crctn;
            var frctn = (n < 1000000000) ? 0.509 : 0.105;
            var lghi = Math.Pow(fctr * (n + frctn * lgest), 1.0/3.0) - crctn;
            var lglo = 2.0 * lgest - lghi;
            var count = 0UL;
            var bnd = new List<logrep>();
            for (uint k = 0, klmt = (uint)(lghi / lb5) + 1; k < klmt; ++k) {
                var p = k * lb5;
                for (uint j = 0, jlmt = (uint)((lghi - p) / lb3) + 1; j < jlmt; ++j) {
                    var q = p + j * lb3;
                    var ir = lghi - q;
                    var lg = q + Math.Floor(ir);
                    count += (ulong)ir + 1;
                    if (lg >= lglo) bnd.Add(new logrep((UInt32)ir, j, k, lg));
                }
            }
            var ndx = (int)(count - (ulong) n);
            bnd.Sort((a, b) => (b.Lg < a.Lg) ? -1 : 1);
            var rslt = bnd[ndx];
            return (long) (Math.Pow(2, rslt.X2) * Math.Pow(3, rslt.X3) * Math.Pow(5, rslt.X5));
        }
    }
}