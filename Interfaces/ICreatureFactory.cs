using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Interfaces
{
    public interface ICreatureFactory
    {
        ICreature Create(Creatures creature);
    }
}
