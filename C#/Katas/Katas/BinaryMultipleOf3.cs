using System.Text.RegularExpressions;

namespace Katas
{
    public class BinaryMultipleOf3
    {
        public static void Main(string[] args)
        {
        }

        public static Regex MultipleOf3()
        {
            return new Regex("^(0|(1(01*0)*10*)+)$|^011$|^000$");
        }
    }
}