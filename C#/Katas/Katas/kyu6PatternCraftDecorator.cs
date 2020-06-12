namespace KatasMarineWeapon
{
    using System;

    public class kyu6PatternCraftDecorator
    {
        public static void Main(string[] args)
        {
            IMarine marine = new Marine(10, 1);
            // Console.WriteLine(marine.Damage);
            // var marineUpgradeWeapon = new MarineWeaponUpgrade(marine).Damage;
            Console.WriteLine(new MarineWeaponUpgrade(marine).Damage);

        }
    }



    public interface IMarine
    {
        int Damage { get; set; }
        int Armor { get; set; }
    }

    public class Marine : IMarine
    {
        public Marine(int damage, int armor)
        {
            Console.WriteLine(damage + " " + armor + " <--- Marine");
            Damage = damage;
            Armor = armor;
        }

        public int Damage { get; set; }
        public int Armor { get; set; }
    }

    public class MarineWeaponUpgrade : IMarine
    {
        private IMarine marine;

        public MarineWeaponUpgrade(IMarine marine)
        {
            this.Damage = marine.Damage + 1;
            this.Armor = marine.Armor;
        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }

    public class MarineArmorUpgrade : IMarine
    {
        private IMarine marine;

        public MarineArmorUpgrade(IMarine marine)
        {
            this.Damage = marine.Damage;
            this.Armor = marine.Armor + 1;

        }

        public int Damage { get; set; }

        public int Armor { get; set; }
    }
}