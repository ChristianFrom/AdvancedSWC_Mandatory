using System.Numerics;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public abstract class WeaponBaseAbstract : IWeapon
    {
        public Vector2 WorldPosition { get { return new Vector2(h.RandomPos(9), h.RandomPos(9)); } set { } }
        public abstract string Name { get; }
        public abstract int DamageStat { get; }

        public Helper h = new Helper();

        public override string ToString()
        {
            return $"{nameof(WorldPosition)}: {WorldPosition}, {nameof(Name)}: {Name}, {nameof(DamageStat)}: {DamageStat}";
        }
    }
}
