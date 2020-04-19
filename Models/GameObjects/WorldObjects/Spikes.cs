using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Models.GameObjects.WorldObjects
{
    public class Spikes : WorldObjectBaseAbstract
    {
        public override string Name { get; set; }

        public Spikes()
        {
            Name = "Spikes";
        }
        public override void UseObject(CreatureBaseAbstract c)
        {
            c.Health -= 10;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(c.Name + " has stepped on some spikes and got hit with 10 damage!");
            Console.ResetColor();
            isUsed = true;
        }
    }
}
