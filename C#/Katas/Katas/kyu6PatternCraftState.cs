namespace KatasCraftState
{
    public class kyu6PatternCraftState
    {

    }

    public partial interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }

    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }

    public class SiegeState : IUnitState
    {
        public SiegeState()
        {
            CanMove = false;
            Damage = 20;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class TankState : IUnitState
    {
        public TankState()
        {
            CanMove = true;
            Damage = 20;
        }

        public bool CanMove { get; set; }
        public int Damage { get; set; }
    }

    public class Tank : IUnit
    {
        public Tank()
        {
            CanMove = true;
            Damage = 5;
        }

        public IUnitState State
        {
            get => null;
            set
            {
                CanMove = value.CanMove;
                Damage = value.Damage;
            }
        }

        public bool CanMove { get; private set; }
        public int Damage { get; private set; }
    }
}