using System;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Factories
{
    public class CreatureFactory : ICreatureFactory
    {
        public CreatureBaseAbstract Create(CreatureBaseAbstract creature)
        {
            if (creature.Name == "Goblin") return new Goblin();

            throw new ArgumentException($"CreatureFactory - no creature available with that this name {creature.Name}");
        }
    }
}
