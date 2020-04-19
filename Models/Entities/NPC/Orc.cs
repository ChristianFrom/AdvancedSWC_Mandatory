using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public class Orc : CreatureBaseAbstract
    {
        public Orc()
        {
            Health = 75;
            Name = "Orc";
            creatureChar = 'O';
            IsDead = false;
            Armour = ArmourMaterial.PlateArmour;
            Weapon = WeaponType.Melee;
            Damage = 20;

        }
    }
}
