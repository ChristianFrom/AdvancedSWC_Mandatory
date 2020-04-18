using System;
using System.Numerics;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public abstract class CreatureBaseAbstract : ICreature
    {

        public Vector2 creaturePosition { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public char creatureChar { get; set; }
        public ArmourMaterial Armour { get; set; }
        public WeaponType Weapon { get; set; }
        public Direction DirectionToMove { get; set; }

        public void Move(GameWorld world)
        {
            Console.WriteLine("old position: " + creaturePosition);
            h.MoveRandomly(this, world);
            Console.WriteLine("new position: " + creaturePosition);
        }

        public Helper h = new Helper();

        public override string ToString()
        {
            return $"{nameof(creaturePosition)}: {creaturePosition}, {nameof(Health)}: {Health}, " +
                   $"{nameof(Damage)}: {Damage}, {nameof(Name)}: {Name}, {nameof(IsDead)}: {IsDead}, " +
                   $"{nameof(creatureChar)}: {creatureChar}, {nameof(Armour)}: {Armour}, {nameof(Weapon)}:" +
                   $" {Weapon}, {nameof(DirectionToMove)}: {DirectionToMove}";
        }
    }
}
