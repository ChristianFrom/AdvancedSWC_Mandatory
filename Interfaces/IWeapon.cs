using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWeapon
    {
        int PositionX { get; }
        int PositionY { get; }
        string Name { get; }
        int DamageStat { get; }
    }
}
