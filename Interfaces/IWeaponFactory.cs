using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWeaponFactory
    {
        IWeapon Create(WeaponType type);
    }
}
