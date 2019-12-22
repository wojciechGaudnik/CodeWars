using System;
using System.Linq;

namespace Katas
{
    public class AreTheyTheSame
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = new int[] {11*11, 121*121, 144*144, 19*19, 161*161, 19*19, 144*144, 19*19};
            a = new[] {2, 2, 3};
            b = new[] {4, 9, 9};
            Console.WriteLine(comp(a, b));
        }

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