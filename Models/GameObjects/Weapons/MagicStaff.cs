
namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class MagicStaff : WeaponBaseAbstract
    {

        public override string Name
        {
            get { return "Magic Staff"; }
        }

        public override int DamageStat
        {
            get { return 25; }
        }
    }
}
