using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Interfaces
{
    public interface ICreature
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
        string Name { get; set; }
        bool IsDead { get; set; }
        ArmourMaterial Armour { get; set; }
        WeaponType Weapon { get; set; }
        Direction DirectionToMove { get; set; }
        
    }
}
