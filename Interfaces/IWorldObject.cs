using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWorldObject
    {
         Vector2 WorldPosition { get; set; }
         string Name { get; set; }
         void UseObject(CreatureBaseAbstract c);
    }
}
