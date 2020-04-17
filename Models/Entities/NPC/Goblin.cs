
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public class Goblin : CreatureBaseAbstract
    {
        public override int PositionX
        {
            get { return h.RandomPos(9);  }
        }

        public override int PositionY
        {
            get { return h.RandomPos(9); }
        }

        public override int Health
        {
            get { return 50; }
        }

        public override int Damage
        {
            get { return 10; }
        }

        public override string Name
        {
            get { return "Goblin";  }
        }

        public override bool IsDead
        {
            get { return false; }
        }

        public override ArmourMaterial Armour
        {
            get { return ArmourMaterial.LeatherArmour; }
        }

        public override WeaponType Weapon
        {
            get { return WeaponType.Melee; }
        }

        public override Direction DirectionToMove
        {
            get { return h.RandomDirection(); }
        }
    }
}
