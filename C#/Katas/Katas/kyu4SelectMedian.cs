using System;

namespace Katas
{
    public class kyu4SelectMedian
    {
        public static IWarrior SelectMedian(IWarrior[] warriors)
        {
            IWarrior[] warriorsCopy = new IWarrior[warriors.Length];
            Array.Copy(warriors, 0, warriorsCopy, 0, warriors.Length);

            (IWarrior a, IWarrior b, IWarrior c, IWarrior d, IWarrior e)
                = (warriorsCopy[0], warriorsCopy[1], warriorsCopy[2], warriorsCopy[3], warriorsCopy[4]);

            if (a.IsBetter(b)) (a, b) = (b, a);
            if (d.IsBetter(e)) (d, e) = (e, d);
            if (a.IsBetter(d)) (a, b, d, e) = (d, e, a, b);

            if (c.IsBetter(b))
            {
                if (d.IsBetter(b)) return (d.IsBetter(c)) ? c : d;
                return (b.IsBetter(e)) ? e : b;
            }

            if (d.IsBetter(c)) return (d.IsBetter(b)) ? b : d;
            return (c.IsBetter(e)) ? e : c;
        }

        public interface IWarrior
        {
            // a.IsBetter(b) returns true if and only if
            // warrior a is no worse than warrior b, i.e. a>=b
            bool IsBetter(IWarrior other);
        }

        public class Warrior : IWarrior
        {
            public int m_internal;

            public static int CompareCount { get; private set; }

            public Warrior(int rank = 0)
            {
                m_internal = rank;
            }

            public bool IsBetter(IWarrior other)
            {
                ++CompareCount;
                if (other == null || !(other is Warrior)) return false;
                return m_internal >= (other as Warrior).m_internal;
            }

            public static void ResetCompareCount()
            {
                CompareCount = 0;
            }
        }
    }
}