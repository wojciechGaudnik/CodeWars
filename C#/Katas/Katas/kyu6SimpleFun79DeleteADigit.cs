using System;

namespace Katas
{
    public class kyu6SimpleFun79DeleteADigit
    {
        public static void Main(string[] args)
        {
            var test = new kyu6SimpleFun79DeleteADigit();
            Console.WriteLine(test.DeleteDigit(152));
        }

        public int DeleteDigit(int n)
        {
            var max = int.MinValue;
            var stringN = n.ToString();
            var nBuff = int.MinValue;
            for (var i = 0; i < stringN.Length; i++)
            {
                nBuff = int.Parse(stringN.Substring(0, i) + stringN.Substring(i + 1));
                if (nBuff > max) max = nBuff;
            }
            return max;
        }

    }
}