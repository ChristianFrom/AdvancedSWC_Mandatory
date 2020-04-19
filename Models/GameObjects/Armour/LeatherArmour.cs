
namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    public class LeatherArmour : ArmourBaseAbstract
    {
        public override string Name
        {
            get { return "Leather Armour"; }
        }


        public override int DefenceStat
        {
            get { return 25; }
        }
    }
}
