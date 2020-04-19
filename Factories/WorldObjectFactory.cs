using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.GameObjects.WorldObjects;

namespace Advanced_Mandatory.Factories
{
    public class WorldObjectFactory : IWorldObjectFactory
    {
        public WorldObjectBaseAbstract Create(WorldObjects worldObject)
        {
            if (worldObject == WorldObjects.HealthPotion) return new HealthPotion();
            if (worldObject == WorldObjects.Spikes) return new Spikes();

            throw new ArgumentException($"WorldObjectFactory - no object available with that this name {worldObject}");
        }
    }
}
