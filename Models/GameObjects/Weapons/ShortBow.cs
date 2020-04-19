
namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class ShortBow : WeaponBaseAbstract
    {
        public override string Name
        {
            get { return "Short Bow"; }
        }

        public override int DamageStat
        {
            get { return 25; }
        }
    }
}
