using System;

namespace Katas
{
    public class AreTheyTheSame
    {
        public static bool comp(int[] a, int[] b)
        {
            if(a == null || b == null || a.Length != b.Length) return false;
            Array.Sort(a);
            Array.Sort(b);
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] * a[i]!= b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}