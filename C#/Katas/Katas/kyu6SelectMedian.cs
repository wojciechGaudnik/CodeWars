using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6SelectMedian
    {
        // public static void Main(string[] args)
        // {
        //     // System.Reflection()
        //     Warrior[] inputTest = {
        //         new Warrior(4),
        //         new Warrior(2),
        //         new Warrior(1),
        //         new Warrior(5),
        //         new Warrior(6),
        //         new Warrior(3),
        //     };
        //
        //     inputTest = inputTest.Skip(1).ToArray();
        //
        //     // Console.WriteLine(string.Join(",", inputTest.Select(w => ((Warrior) w).m_internal)));
        //     // return;
        //
        //
        //     Warrior[] input = {
        //         new Warrior(1),
        //         new Warrior(4),
        //         new Warrior(5),
        //         new Warrior(3),
        //         new Warrior(2),
        //     };
        //     var target = 3;
        //     Warrior.ResetCompareCount();
        //     Console.WriteLine(((Warrior)SelectMedian(input, target)).m_internal + " <--- target");
        //     Console.WriteLine(Warrior.CompareCount + " <---CompareCount");
        // }

        public static IWarrior SelectMedian(IWarrior[] warriors, int target)
        {
            Console.WriteLine(string.Join(",", warriors.Select(w => ((Warrior) w).m_internal)));

            var k = target;
            var n = warriors.Length;
            var pivot = warriors[warriors.Length - 1];
            var i = 0;
            for (var j = 0; j < n - 1; j++)
            {
               if (pivot.IsBetter(warriors[j]))
               {
                   (warriors[j], warriors[i]) = (warriors[i], warriors[j]);
                   i++;
               }
               Console.WriteLine(string.Join(",", warriors.Select(w => ((Warrior) w).m_internal)));
            }
            var last = warriors.Length - 1;
            (warriors[last], warriors[i]) = (warriors[i], warriors[last]);
            Console.WriteLine(string.Join(",", warriors.Select(w => ((Warrior) w).m_internal)));
            if (i == n - k) return warriors[i];
            return (i < n - k) ? SelectMedian(warriors.Skip(i).ToArray(), target) : SelectMedian(warriors.Take(i).ToArray(), target);
        }
    }

    // for (i = 0; i < n - 1; i++)
    // {
    // for (var j = i + 1; j < n; j++)
    // {
    //     if (pivot.IsBetter(warriors[j]))
    //     {
    //         (warriors[j], warriors[i]) = (warriors[i], warriors[j]);
    //         break;
    //     }
    // }
    // }


    public interface IWarrior {
        // a.IsBetter(b) returns true if and only if
        // warrior a is no worse than warrior b, i.e. a>=b
        bool IsBetter(IWarrior other);
    }

    public class Warrior : IWarrior {
        public int m_internal;

        public static int CompareCount {get; private set;}

        public Warrior(int rank=0){
            m_internal = rank;
        }

        public bool IsBetter(IWarrior other){
            ++CompareCount;
            if(other == null || !(other is Warrior)) return false;
            return m_internal >= (other as Warrior).m_internal;
        }

        public static void ResetCompareCount(){
            CompareCount = 0;
        }
    }
}