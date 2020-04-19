using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public class Elf : CreatureBaseAbstract
    {
        public Elf()
        {
            Health = 65;
            Name = "Elf";
            creatureChar = 'E';
            IsDead = false;
            Armour = ArmourMaterial.ClothArmour;
            Weapon = WeaponType.Magic;
            Damage = 20;
        }
    }
}
