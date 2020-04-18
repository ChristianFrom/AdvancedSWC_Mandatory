
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class IronSword : WeaponBaseAbstract
    {
        public override int PositionX
        {
            get { return h.RandomPos(9); }
        }

        public override int PositionY
        {
            get { return h.RandomPos(9); }
        }

        public override string Name
        {
            get { return "Iron Sword"; }
        }

        public override int DamageStat
        {
            get { return 25; }
        }
    }
}
