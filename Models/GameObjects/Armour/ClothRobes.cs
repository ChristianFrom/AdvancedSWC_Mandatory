
namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    public class ClothRobes : ArmourBaseAbstract
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
            get { return "Cloth Robes"; }
        }


        public override int DefenceStat
        {
            get { return 10; }
        }
    }
}
