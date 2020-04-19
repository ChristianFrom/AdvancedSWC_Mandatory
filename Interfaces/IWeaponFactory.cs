
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Models.GameObjects.Weapons;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWeaponFactory
    {
        WeaponBaseAbstract Create(WeaponType type);
    }
}
