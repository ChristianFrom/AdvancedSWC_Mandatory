using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.GameObjects.Armour
{
    /// <summary>
    /// Base class for every armour
    /// </summary>
    public abstract class ArmourBaseAbstract : IArmour
    {
        public abstract int PositionX { get; }
        public abstract int PositionY { get; }
        public abstract string Name { get; }
        public abstract int DefenceStat { get; }

        public Helper h = new Helper();

        public override string ToString()
        {
            return $"{nameof(PositionX)}: {PositionX}, {nameof(PositionY)}: {PositionY}, {nameof(Name)}: {Name}, {nameof(DefenceStat)}: {DefenceStat}";
        }
    }
}
