using System;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Factories
{
    public class CreatureFactory : ICreatureFactory
    {
        public CreatureBaseAbstract Create(Creatures creature)
        {
            if (creature == Creatures.Goblin) return new Goblin();

            throw new ArgumentException($"CreatureFactory - no creature available with that this name {creature}");
        }
    }
}
