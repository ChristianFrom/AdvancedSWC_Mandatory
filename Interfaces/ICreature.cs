using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Interfaces
{
    public interface ICreature
    {
        /// <summary>
        /// All creatures have a X position in the world
        /// </summary>
        int PositionX { get; }

        /// <summary>
        /// All creatures have a Y position in the world
        /// </summary>
        int PositionY { get; }

        /// <summary>
        /// All creatures have a base health, starts at 100
        /// </summary>
        int Health { get; }

        /// <summary>
        /// All creatures have a base damage, starts at 20
        /// </summary>
        int Damage { get; }

        /// <summary>
        /// All creatures have a name, doesn't have to be unique
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Boolean to indicate if a creature is dead.
        /// </summary>
        bool IsDead { get; }

        /// <summary>
        /// Indicates which armour material they are equipped with, can be cloth, leather or plate
        /// </summary>
        ArmourMaterial Armour { get; }

        /// <summary>
        /// Indicates which weapon type they are attacking with, can be magic, melee or range
        /// </summary>
        WeaponType Weapon { get; }

        /// <summary>
        /// Indicates which direction the creature moves
        /// </summary>
        Direction DirectionToMove { get; }
    }
}
