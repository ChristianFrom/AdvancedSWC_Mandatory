
namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    class PlateArmour : ArmourBaseAbstract
    {
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

