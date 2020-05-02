using System.Linq;

namespace Katas
{
    public class Test
    {
        public static int SimpleProgramming()
        {
            string text = System.IO.File.ReadAllText("data.dat");
            var anwer = 0;
            foreach (var one in text.Split())
            {
                if (one.Trim().Count(c => c == '0') % 3 == 0 || one.Trim().Count(c => c == '1') % 2 == 0) anwer++;
            }
            return anwer;
        }
    }
}