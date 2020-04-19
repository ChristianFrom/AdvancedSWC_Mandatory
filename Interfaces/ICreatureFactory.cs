using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Interfaces
{
    public interface ICreatureFactory
    {
        CreatureBaseAbstract Create(Creatures creature);
    }
}
