using System;

namespace Katas
{
    public class kyu5WhatsAPerfectPowerAnyway
    {
        public static (int, int)? IsPerfectPower(int n)
        {
            if (n < 4) return null;
            var b = (int)Math.Round(Math.Sqrt(n));
            var e = 2;
            while (b >= 2)
            {
                var bBuff = b;

                for (; b - bBuff < e; b++)
                {
                    for (var i = 2; i <= e + 1; i++)
                    {
                        if ((int) Math.Pow(b, i) == n) return (b, i);
                        if ((int) Math.Pow(b + i, i) == n) return (b + i, i);
                    }
                }
                e += 66;
                b = (int)Math.Round(Math.Sqrt(bBuff));
            }
            return null;
        }
    }
}