
namespace Advanced_Mandatory.Interfaces

{
    public interface IArmour
    {
        /// <summary>
        /// Every armour has a X position in the world
        /// </summary>
        int PositionX { get; }

        /// <summary>
        /// Every armour has a Y position in the world
        /// </summary>
        /// 
        int PositionY { get; }

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
