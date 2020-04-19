using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Abstract_Classes
{
    public abstract class WorldObjectBaseAbstract : IWorldObject
    {
        public Vector2 WorldPosition { get { return new Vector2(h.RandomPos(9), h.RandomPos(9)); } set { } }
        public abstract string Name { get; set; }
        public bool isUsed { get; set; }

        Helper h = new Helper();

        public abstract void UseObject(CreatureBaseAbstract c);

        public override string ToString()
        {
            return $"{nameof(WorldPosition)}: {WorldPosition}, {nameof(Name)}: {Name}";
        }
    }
}
