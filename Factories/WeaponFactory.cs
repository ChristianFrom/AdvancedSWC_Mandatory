using System;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.GameObjects.Weapons;

namespace Advanced_Mandatory.Factories
{
    public class WeaponFactory : IWeaponFactory
    {
        public WeaponBaseAbstract Create(WeaponType type)
        {
            if (type == WeaponType.Melee) return new IronSword();
            if (type == WeaponType.Magic) return new MagicStaff();
            if (type == WeaponType.Ranged) return new ShortBow();

            throw new ArgumentException($"WeaponFactory - no weapon available for weapon type {type}");
        }
    }
}
