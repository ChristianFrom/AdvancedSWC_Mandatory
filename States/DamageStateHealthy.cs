using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.States
{
    public class DamageStateHealthy : IState
    {
        public void CalculateDamage(ICreature aC, ICreature dC)
        {
            if (aC.Damage < dC.Health)
            {
                int newHealth = dC.Health -= aC.Damage;
                dC.Health = newHealth;
            }
        }
    }
}
