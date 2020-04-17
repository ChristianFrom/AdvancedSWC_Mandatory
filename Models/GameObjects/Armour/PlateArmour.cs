
namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    class PlateArmour : ArmourBaseAbstract
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
            get { return "Plate Armour"; }
        }

        public override int DefenceStat
        {
            get { return 50; }
        }
    }
}

