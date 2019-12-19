using System;
using System.Linq;

namespace Katas
{
    public class PersistentBugger
    {
        static void Main(string[] args)
        {

        }

        public static int Persistence(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                // n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
                n = n.ToString().ToCharArray().Select(s => Convert.ToInt32(s.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }

    }
}