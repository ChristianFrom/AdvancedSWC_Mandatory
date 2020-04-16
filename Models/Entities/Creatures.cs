using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models
{
    public class Creatures : CreatureAbstract
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int baseHealth { get; set; }
        public int baseDamage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }


        public Creatures(int positionX, int positionY, int damage, string name, bool isDead, ArmourMaterial armour, WeaponType weapon, Direction directionToMove) : base(positionX, positionY, damage, name, isDead, armour, weapon, directionToMove)
        {
        }


        public Direction RandomDirection()
        {
            Random r = new Random();
            Array direction = Enum.GetValues(typeof(Direction));
            Direction d = (Direction)direction.GetValue(r.Next(0, direction.Length));
            return d;

        }
    }
}
