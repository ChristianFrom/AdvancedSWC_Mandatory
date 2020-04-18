
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Advanced_Mandatory.Interfaces
{
    public interface IState
    {
        void CalculateDamage(ICreature AttackerCreature, ICreature DefenderCreature);
    }
}