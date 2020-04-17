using System;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

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

    }
}
