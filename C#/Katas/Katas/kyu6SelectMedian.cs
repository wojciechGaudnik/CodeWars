using System;
using System.Collections;
using System.Collections.Generic;

namespace Katas
{
    public class kyu6SelectMedian
    {
        public static void Main(string[] args)
        {
            // System.Reflection()
            Warrior[] input = {
                new Warrior(1),
                new Warrior(4),
                new Warrior(5),
                new Warrior(3),
                new Warrior(2),
            };
            Warrior.ResetCompareCount();
            Console.WriteLine(((Warrior)SelectMedian(input)).m_internal);
            Console.WriteLine(Warrior.CompareCount);
        }

        public static IWarrior SelectMedian(IWarrior[] warriors)
        {
            var betterList = new ArrayList();
            var worstList = new ArrayList();
            for (var i = 0; i < warriors.Length - 2; i += 2)
            {
                if (warriors[i].IsBetter(warriors[i + 1]))
                {
                    betterList.Add(warriors[i]);
                    worstList.Add(warriors[i + 1]);
                }
                else
                {
                    betterList.Add(warriors[i + 1]);
                    worstList.Add(warriors[i]);
                }
            }

            if (((IWarrior) betterList[1]).IsBetter((IWarrior) betterList[0]))
            {
                (betterList[0], betterList[1]) = (betterList[1], betterList[0]);
            };
            if (((IWarrior) worstList[1]).IsBetter((IWarrior) worstList[0]))
            {
                (worstList[0], worstList[1]) = (worstList[1], worstList[0]);
            };

            if (warriors[4].IsBetter((IWarrior) betterList[0]))
            {
                return ((IWarrior)betterList[1]).IsBetter((IWarrior)worstList[0]) ? (IWarrior)betterList[1]:(IWarrior)worstList[0];
            }

            if (warriors[4].IsBetter((IWarrior) worstList[0]))
            {
                return ((IWarrior)betterList[1]).IsBetter((IWarrior)worstList[0]) ? (IWarrior)worstList[0] : (IWarrior)betterList[1];
            }
            return ((IWarrior)betterList[1]).IsBetter((IWarrior)worstList[0]) ? (IWarrior)worstList[0] : (IWarrior)betterList[1];












            // Here be code
            throw new NotImplementedException();
        }
    }


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