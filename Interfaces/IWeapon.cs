
using System.Numerics;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWeapon
    {
        Vector2 WorldPosition { get; set; }
        string Name { get; }
        int DamageStat { get; }
    }
}
