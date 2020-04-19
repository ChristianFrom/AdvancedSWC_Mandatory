using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;

namespace Advanced_Mandatory.Models.GameObjects.WorldObjects
{
    abstract class HealthPotion : WorldObjectBaseAbstract
    {

        public HealthPotion()
        { 
            Name = "Health Potion";
        }



        public override void UseObject()
        {
            throw new NotImplementedException();
        }
    }
}
