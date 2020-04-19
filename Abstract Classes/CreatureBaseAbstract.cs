using System;
using System.Numerics;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.States;

namespace Advanced_Mandatory.Models.Entities.NPC
{
    public abstract class CreatureBaseAbstract : ICreature
    {

        public Vector2 WorldPosition { get { return new Vector2(h.RandomPos(9), h.RandomPos(9)); } set { } }
        public int BaseHealth { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get { return CheckIfDead();} set { }}
        public char creatureChar { get; set; }
        public ArmourMaterial Armour { get; set; }
        public WeaponType Weapon { get; set; }
        public Direction DirectionToMove { get { return RandomDirection();} set { } }

        public Helper h = new Helper();


        public void MoveRandomly()
        {
            Random r = new Random();
            int x = r.Next(1, 2);
            int y = r.Next(1, 2);

            WorldPosition = new Vector2(x, y); 
        }

        public bool CheckIfDead()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Oh no " + Name + " died!");
                return IsDead = true;
            }

            return false;
        }

        public void ReactOnItem(WorldObjectBaseAbstract o)
        {
            if (o.WorldPosition == WorldPosition)
            {
                o.UseObject(this);
            }
        }

        public void ReactOnCreature(CreatureBaseAbstract c)
        {
            if (c.WorldPosition == WorldPosition)
            {
                Attack(this, c);
            }
        }


        public void Attack(CreatureBaseAbstract a, CreatureBaseAbstract b)
        {
            Console.WriteLine(a.Name + " is attacking " + b.Name + "!");
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

            Console.WriteLine(b.Name + " got hit with: " + a.Damage + " and now has: " + b.Health + " health left.");
        }


        public void resetDamage(ICreature a)
        {
            a.Damage = 10;
        }

        public Direction RandomDirection()
        {
            Random r = new Random();
            Array direction = Enum.GetValues(typeof(Direction));
            Direction d = (Direction)direction.GetValue(r.Next(0, direction.Length));
            return d;
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
