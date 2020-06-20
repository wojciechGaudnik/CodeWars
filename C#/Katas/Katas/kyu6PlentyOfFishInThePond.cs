using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6PlentyOfFishInThePond
    {
        public int fish(string shoal)
        {
            Console.WriteLine(shoal);
            var listShoal = shoal.Select(c => int.Parse(c.ToString())).OrderBy(c => c).ToList();
            var dict = new Dictionary<int, int>();
            var value = 4;
            for (var i = 1; i < 100; i++)
            {
                dict.Add(i, value);
                value += 4;
            }
            var size = 1;
            var stomach = 0;
            Console.WriteLine(string.Join("", listShoal));
            for (var i = 0; i < listShoal.Count; i++)
            {
                if(listShoal[i] > size) break;
                stomach += listShoal[i];
                if (dict.ContainsKey(size) && stomach >= dict[size])
                {
                    stomach -= dict[size];
                    size++;
                }
            }
            return size;
        }
    }
}