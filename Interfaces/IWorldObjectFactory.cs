using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Enums;

namespace Advanced_Mandatory.Interfaces
{
    public interface IWorldObjectFactory
    {
        WorldObjectBaseAbstract Create(WorldObjects worldObject);
    }
}
