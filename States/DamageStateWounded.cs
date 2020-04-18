using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.States
{
    public class DamageStateWounded : IState
    {
        public void CalculateDamage(ICreature aC, ICreature dC)
        {
            int newDamage;

                newDamage = aC.Damage - 5;
                aC.Damage = newDamage;
                if (newDamage < dC.Health)
                {
                    int newHealth = dC.Health -= newDamage;
                    dC.Health = newHealth;
                }

        }
    }
}
