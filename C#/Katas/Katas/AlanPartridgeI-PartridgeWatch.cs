using System;
using System.Linq;
using System.Text;

namespace Katas
{
    public class AlanPartridgeIPartridgeWatch
    {
        public static string Part(string[] x)
        {
//            Array.ForEach(x, Console.WriteLine);
            Console.WriteLine("[\"{0}\"]", string.Join("\", \"", x));
            string[] terms = {"Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad"};
            var count = 0;
            foreach (var VARIABLE in x)
            {
                if (terms.Contains(VARIABLE)) count++;
            }
            if(count == 0) return "Lynn, I've pierced my foot on a spike!!";
            return "Mine's a Pint" + new StringBuilder(count).Insert(0, "!", count);
        }
    }
}