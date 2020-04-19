using System;
using System.Numerics;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.States;

namespace Advanced_Mandatory.Models
{
    public class Helper
    {

        public int RandomPos(int maxValue)
        {
            Random r = new Random();
            int i = r.Next(maxValue);
            return i;
        }

        public Direction RandomDirection()
        {
            Random r = new Random();
            Array direction = Enum.GetValues(typeof(Direction));
            Direction d = (Direction)direction.GetValue(r.Next(0, direction.Length));
            return d;
        }

        public bool MoveRandomly(ICreature c, GameWorld world)
        {
            Random r = new Random();
            int x = r.Next(1, 2);
            int y = r.Next(1, 2);

            c.WorldPosition = new Vector2(x, y);

            //world.OnWorldChanged(EventArgs.Empty);
            return true;
        }

        
    }
}
