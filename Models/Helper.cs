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

    }
}
