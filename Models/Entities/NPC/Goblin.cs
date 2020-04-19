using System.Numerics;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public class Goblin : CreatureBaseAbstract
    {
        public Goblin()
        {
            BaseHealth = 50;
            Health = 50;
            Name = "Goblin";
            creatureChar = 'G';
            IsDead = false;
            Armour = ArmourMaterial.LeatherArmour;
            Weapon = WeaponType.Ranged;
            Damage = 10;
        }

    }
}
