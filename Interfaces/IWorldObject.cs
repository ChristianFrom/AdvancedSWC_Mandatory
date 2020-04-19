using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWorldObject
    {
         Vector2 WorldPosition { get; set; }
         string Name { get; set; }
         void UseObject();
    }
}
