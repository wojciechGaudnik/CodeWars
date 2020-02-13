using System;

namespace Katas
{
    public class kyu6BuildTower
    {
        public static void Main(string[] args)
        {
            foreach (var one in TowerBuilder(3))
            {
                Console.WriteLine(one);
            }
        }

        public static string[] TowerBuilder(int nFloors)
        {
            var answer = new string[nFloors];
            var l = 0;
            var r = 0;
            var m = (nFloors * 2) - 1;
            for (var i = 0; i < nFloors; i++)
            {
                answer[i] =
                    new string(' ', l) +
                    new string('*', m - (l + r)) +
                    new string(' ', r);
                l++;
                r++;
            }
            Array.Reverse(answer);
            return answer;
        }
    }
}