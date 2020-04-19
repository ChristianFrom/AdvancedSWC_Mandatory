using System;
using System.Numerics;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.States;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public abstract class CreatureBaseAbstract : ICreature
    {

        public Vector2 WorldPosition { get { return new Vector2(h.RandomPos(9), h.RandomPos(9)); } set { } }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public char creatureChar { get; set; }
        public ArmourMaterial Armour { get; set; }
        public WeaponType Weapon { get; set; }
        public Direction DirectionToMove { get; set; }

        public Helper h = new Helper();


        public void Move(GameWorld world)
        {
            Console.WriteLine("old position: " + WorldPosition);
            h.MoveRandomly(this, world);
            Console.WriteLine("new position: " + WorldPosition);
        }

        public void ReactOnItem()
        {
            throw new NotImplementedException();
        }

        public void Attack(CreatureBaseAbstract a, CreatureBaseAbstract b)
        {
            IState damageState = new DamageStateHealthy();

            if (a.Health < 25)
            {
                damageState = new DamageStateWounded();
                damageState.CalculateDamage(a, b);
            }

            else if (a.Health > 25)
            {
                damageState = new DamageStateHealthy();
                resetDamage(a);
                damageState.CalculateDamage(a, b);
            }

        }

        public void resetDamage(ICreature a)
        {
            a.Damage = 10;
        }

        

        public override string ToString()
        {
            return $"{nameof(WorldPosition)}: {WorldPosition}, {nameof(Health)}: {Health}, " +
                   $"{nameof(Damage)}: {Damage}, {nameof(Name)}: {Name}, {nameof(IsDead)}: {IsDead}, " +
                   $"{nameof(creatureChar)}: {creatureChar}, {nameof(Armour)}: {Armour}, {nameof(Weapon)}:" +
                   $" {Weapon}, {nameof(DirectionToMove)}: {DirectionToMove}";
        }
    }
}
