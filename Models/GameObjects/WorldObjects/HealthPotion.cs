﻿using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Models.GameObjects.WorldObjects
{
    public class HealthPotion : WorldObjectBaseAbstract
    {
        public override string Name { get; set; }


        public HealthPotion()
        { 
            Name = "Health Potion";
        }


        public override void UseObject(CreatureBaseAbstract c)
        {
            c.Health += 25;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(c.Name + " has been healed by 25");
            Console.ResetColor();
        }
    }
}