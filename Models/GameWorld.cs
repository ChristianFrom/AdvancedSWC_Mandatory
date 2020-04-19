using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Advanced_Mandatory.Abstract_Classes;
using Advanced_Mandatory.Enums;
using Advanced_Mandatory.Factories;
using Advanced_Mandatory.Interfaces;
using Advanced_Mandatory.Models.Entities.NPC;

namespace Advanced_Mandatory.Models
{
    public class GameWorld
    {
        public Vector2 player;
        public char[,] World;
        public int WorldSize;
        public String horizontalLine = "-";
        public List<CreatureBaseAbstract> creatures = new List<CreatureBaseAbstract>();
        public List<WorldObjectBaseAbstract> worldObjects = new List<WorldObjectBaseAbstract>();
        public CreatureFactory cF = new CreatureFactory();
        public WorldObjectFactory oF = new WorldObjectFactory();

        public GameWorld(int worldSize)
        {
            player = new Vector2(10, 10);
            WorldSize = worldSize;
            World = new char[worldSize, worldSize];

            CreateCreatures(3);
            CreateWorldObjects(4);

        }


        public List<CreatureBaseAbstract> CreateCreatures(int numberofCreatures)
        {
            for (int i = 0; i <= numberofCreatures; i++)
            {
                // Make random creatures?
                creatures.Add(cF.Create(Creatures.Goblin));
                creatures.Add(cF.Create(Creatures.Orc));
                creatures.Add(cF.Create(Creatures.Elf));
            }

            return creatures;
        }

        public List<WorldObjectBaseAbstract> CreateWorldObjects(int numberOfObjects)
        {
            for (int i = 0; i <= numberOfObjects; i++)
            {
                // Make random objects?
                worldObjects.Add(oF.Create(WorldObjects.HealthPotion));
                worldObjects.Add(oF.Create(WorldObjects.Spikes));
            }

            return worldObjects;
        }
        
       
        public void DrawWorld()
        {
            Console.Clear();
            Console.WriteLine(horizontalLine);
            for (int r = 0; r < WorldSize; r++)
            {
                Console.WriteLine($"|{GetRowString(r)}|");
            }

            Console.WriteLine(horizontalLine);
        }

        public String GetRowString(int r)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < WorldSize; i++)
            {
                if (r == player.Y && i == player.X)
                {
                    sb.Append('P');
                }
                else
                {
                    sb.Append(' ');
                }
            }

            return sb.ToString();
        }

    }
}
