using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    class LeatherArmour : ArmourBaseAbstract
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
            get { return "Leather Armour"; }
        }


        public override int DefenceStat
        {
            get { return 25; }
        }
    }
}
