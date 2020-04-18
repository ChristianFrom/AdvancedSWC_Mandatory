using System.Numerics;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Models;

namespace Advanced_Mandatory.Interfaces
{
    public interface ICreature
    {
        /// <summary>
        /// Creature's position in the world
        /// </summary>
        Vector2 creaturePosition { get; set; }

        /// <summary>
        /// All creatures have a base health, starts at 50
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// All creatures have a base damage, starts at 10
        /// </summary>
        int Damage { get; set; }

        /// <summary>
        /// All creatures have a name, doesn't have to be unique
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Boolean to indicate if a creature is dead.
        /// </summary>
        bool IsDead { get; set; }


        /// <summary>
        /// Indicates which char is used to represent the creature in the world
        /// </summary>
        char creatureChar { get; set; }

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
        Direction DirectionToMove { get; set; }

        void Move(GameWorld world);
    }
}
