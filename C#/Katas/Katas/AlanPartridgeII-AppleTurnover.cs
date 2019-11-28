using System;

namespace Katas
{
    public class AlanPartridgeII_AppleTurnover
    {
        public static string Apple(object n)
        {
            Console.WriteLine(Math.Pow(Convert.ToDouble(n), 2));

            return (Math.Pow(Convert.ToDouble(n), 2) < 1000)?"Help yourself to a honeycomb Yorkie for the glovebox.":"It's hotter than the sun!!";
        }
    }
}