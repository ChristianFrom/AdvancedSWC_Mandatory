using System;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.GameObjects.Armour;
using Advanced_Mandatory.Models.GameObjects.Weapons;

namespace Advanced_Mandatory.Factories
{
    public class ArmourFactory : IArmourFactory
    {
        public ArmourBaseAbstract Create(ArmourMaterial material)
        {
            if (material == ArmourMaterial.ClothArmour) return new ClothRobes();
            if (material == ArmourMaterial.LeatherArmour) return new LeatherArmour();
            if (material == ArmourMaterial.PlateArmour) return new PlateArmour();

            throw new ArgumentException($"ArmourFactory - no armour available for armour material {material}");
        }
    }
}
