using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Abstract_Classes
{
    public class CreatureAbstract : ICreature
    {

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Damage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }
        public ArmourMaterial Armour { get; set; }
        public WeaponType Weapon { get; set; }
        public Direction DirectionToMove { get; set; }

        // Fields
        private int _health = 100;


        public int Health
        {
            get => _health;
            set
            {
                if (value <= 0) IsDead = true;
                _health = value;
            }
        }

        public CreatureAbstract(int positionX, int positionY, int damage, string name, bool isDead, ArmourMaterial armour, WeaponType weapon, Direction directionToMove)
        {
            PositionX = positionX;
            PositionY = positionY;
            Damage = damage;
            Name = name;
            IsDead = isDead;
            Armour = armour;
            Weapon = weapon;
            DirectionToMove = directionToMove;
        }

    }
}
