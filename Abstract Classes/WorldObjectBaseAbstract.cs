﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models;

namespace Advanced_Mandatory.Abstract_Classes
{
    public abstract class WorldObjectBaseAbstract : IWorldObject
    {
        public Vector2 WorldPosition { get { return new Vector2(h.RandomPos(9), h.RandomPos(9)); } set { } }
        public abstract string Name { get; set; }

        Helper h = new Helper();

        public override string ToString()
        {
            return $"{nameof(WorldPosition)}: {WorldPosition}, {nameof(Name)}: {Name}";
        }
    }
}
