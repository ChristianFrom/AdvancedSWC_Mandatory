using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Models.GameObjects.Armour;

namespace Advanced_Mandatory.Interfaces
{
    public interface IArmourFactory
    {
        ArmourBaseAbstract Create(ArmourMaterial material);
    }
}
