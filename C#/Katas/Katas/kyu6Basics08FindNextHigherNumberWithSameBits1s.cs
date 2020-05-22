using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6Basics08FindNextHigherNumberWithSameBits1s
    {
        public static void Main(string[] args)
        {

            var test = new kyu6Basics08FindNextHigherNumberWithSameBits1s();

            // Console.WriteLine(test.nextHigher(1022));
            Console.WriteLine(1279);

            Console.WriteLine("0" + Convert.ToString(1022, 2));
            Console.WriteLine("0" + Convert.ToString(1279, 2));
        }



        public int nextHigher(int value)
        {
            var numberOfOnes = Convert.ToString(value++, 2).Count(c => c == '1');
            while (numberOfOnes != Convert.ToString(value, 2).Count(c => c == '1')) value++;
            return value;
        }
    }
}