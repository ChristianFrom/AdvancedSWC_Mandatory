using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public abstract class WeaponBaseAbstract : IWeapon
    {
        public abstract int PositionX { get; }
        public abstract int PositionY { get; }
        public abstract string Name { get; }
        public abstract int DamageStat { get; }

        public Helper h = new Helper();

        public override string ToString()
        {
            return $"{nameof(PositionX)}: {PositionX}, {nameof(PositionY)}: {PositionY}, {nameof(Name)}: {Name}, {nameof(DamageStat)}: {DamageStat}";
        }
    }
}
