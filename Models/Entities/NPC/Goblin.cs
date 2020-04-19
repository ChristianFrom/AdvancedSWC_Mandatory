using System.Numerics;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public class Goblin : CreatureBaseAbstract
    {
        public Goblin() : base()
        {
            Health = 50;
            Name = "Goblin";
            creatureChar = 'G';
            IsDead = false;
            Armour = ArmourMaterial.LeatherArmour;
            Weapon = WeaponType.Melee;
            Damage = 10;
            DirectionToMove = Direction.Up;
        }

    }
}
