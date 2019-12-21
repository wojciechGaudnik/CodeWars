using System;
using System.Linq;

namespace Katas
{
    public class IQTest
    {
        public static int Test(string word)
        {
            var array = word.Split(" ").Select(w => int.Parse(w)).ToArray();
            var search = 0;
            if (array[0] % 2 == 0 && array[1] % 2 == 0) search = 1;
            if (array[0] % 2 == 0 && array[1] % 2 == 1) search = (array[2] % 2 == 1)? 0 : 1;
            if (array[0] % 2 == 1 && array[1] % 2 == 0) search = (array[2] % 2 == 1)? 0 : 1;
            foreach (var i in array)
            {
                if(i % 2 == search) return Array.IndexOf(array, i) + 1;
            }

            return -1;
        }
    }
}