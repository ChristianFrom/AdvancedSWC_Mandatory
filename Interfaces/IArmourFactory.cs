using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Interfaces
{
    public interface IArmourFactory
    {
        IArmour Create(ArmourMaterial material);
    }
}
