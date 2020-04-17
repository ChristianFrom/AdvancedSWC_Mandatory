using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Mandatory.Models.GameObjects.Weapons
{
    public class MagicStaff : WeaponBaseAbstract
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
            get { return "Magic Staff"; }
        }

        public override int DamageStat
        {
            get { return 25; }
        }
    }
}
