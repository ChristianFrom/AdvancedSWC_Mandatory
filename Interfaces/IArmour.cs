
using System.Numerics;

namespace Advanced_Mandatory.Interfaces

{
    public interface IArmour
    {
        Vector2 WorldPosition { get; set; }

        /// <summary>
        /// Every armour has a name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Indicates how much of a defence boost, the armour gives
        /// </summary>
        int DefenceStat { get; }

    }
}
