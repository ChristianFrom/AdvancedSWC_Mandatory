using System;
using System.Collections.Generic;
using System.Text;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Interfaces;

namespace Advanced_Mandatory.Models.Items
{
    class Armour : IGameObject
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public string Name { get; set; }
        public ArmourMaterial Material { get; set; }
        public int DefenceStat { get; set; }

        public Armour(int positionX, int positionY, string name, ArmourMaterial material, int defenceStat)
        {
            PositionX = positionX;
            PositionY = positionY;
            Name = name;
            Material = material;
            DefenceStat = defenceStat;
        }

        public int GiveDefenceStat(ArmourMaterial material)
        {
            if (material == ArmourMaterial.ClothArmour)
            {
                DefenceStat = 5;
            }
            else if (material == ArmourMaterial.LeatherArmour)
            {
                DefenceStat = 10;
            }
            else if (material == ArmourMaterial.PlateArmour)
            {
                DefenceStat = 15;
            }

            return DefenceStat;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Material)}: {Material}, {nameof(DefenceStat)}: {DefenceStat}";
        }
    }
}
