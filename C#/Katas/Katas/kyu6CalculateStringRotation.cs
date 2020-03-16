using System;

namespace Katas
{
    public class kyu6CalculateStringRotation
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ShiftedDiff("eecoff","coffee"));
            Console.WriteLine("abcd".Substring(0, 1));
            Console.WriteLine("abcd".Substring(1, 1));
            Console.WriteLine("abcd".Substring(2, 1));
            Console.WriteLine("abcd".Substring(3, 1));
        }

        public static int ShiftedDiff(string first, string second)
        {
            if (first.Length != second.Length) return -1;
            if (first.Equals(second)) return 0;
            for (var i = 0; i < first.Length; i++)
            {
                first = first.Substring(first.Length - 1, 1) + first.Substring(0, first.Length - 1);
                if (first.Equals(second)) return i + 1;
            }
            return -1;
        }

    }
}