
namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class ShortBow : WeaponBaseAbstract
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
            get { return "Short Bow"; }
        }

        public override int DamageStat
        {
            get { return 25; }
        }
    }
}
