using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public abstract class CreatureBaseAbstract : ICreature
    {
        public abstract int PositionX { get; }
        public abstract int PositionY { get; }
        public abstract int Health { get; }
        public abstract int Damage { get; }
        public abstract string Name { get; }
        public abstract bool IsDead { get; }
        public abstract ArmourMaterial Armour { get; }
        public abstract WeaponType Weapon { get; }
        public abstract Direction DirectionToMove { get; }

        public Helper h = new Helper();


        public override string ToString()
        {
            return $"{nameof(PositionX)}: {PositionX}, {nameof(PositionY)}: {PositionY}, {nameof(Health)}: {Health}, " +
                   $"{nameof(Damage)}: {Damage}, {nameof(Name)}: {Name}, {nameof(IsDead)}: {IsDead}, {nameof(Armour)}: " +
                   $"{Armour}, {nameof(Weapon)}: {Weapon}, {nameof(DirectionToMove)}: {DirectionToMove}";
        }
    }
}
