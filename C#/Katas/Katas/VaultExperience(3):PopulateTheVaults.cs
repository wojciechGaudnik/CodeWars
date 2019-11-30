using System;
using System.Collections.Generic;

namespace Katas
{
    public class VaultExperience_3__PopulateTheVaults
    {
        public static List<Dweller> PopulateMyVault(int countOfDweller)
        {
            List<Dweller> dwellers = new List<Dweller>();
            if (countOfDweller == 0) return dwellers;
            int men = 0;
            int women = 0;
            dwellers.Add(new Dweller(Gender.Mr, Position.overseer));
            men++;
            if (countOfDweller > 50)
            {
                dwellers.Add(new Dweller(Gender.Mrs, Position.overseer));
                women++;
            }
            while (dwellers.Count < countOfDweller)
            {
                if (men >= women)
                {
                    dwellers.Add(new Dweller(Gender.Mrs, Position.none));
                    women++;
                }
                else
                {
                    dwellers.Add(new Dweller(Gender.Mr, Position.none));
                    men++;
                }
            }
            return dwellers;
        }
    }

    public class Dweller
    {
        public Gender Sex { get; set; }

        public Position Work { get; set; }

        public Dweller() : this(Gender.Mr, Position.none) { }

        public Dweller(Gender sex) : this(sex, Position.none) { }

        public Dweller(Gender sex, Position work)
        {
            Sex = sex;
            Work = work;
        }
    }

    public enum Gender
    {
        Mr,
        Mrs
    }

    public enum Position
    {
        overseer,
        none
    }
}