
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class IronSword : WeaponBaseAbstract
    {
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
