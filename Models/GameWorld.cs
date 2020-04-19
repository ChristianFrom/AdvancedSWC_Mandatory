using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
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
        public CreatureFactory cF = new CreatureFactory();

        public GameWorld(int worldSize)
        {
            player = new Vector2(10, 10);
            WorldSize = worldSize;
            World = new char[worldSize, worldSize];

            for (int i = 0; i < worldSize + 2; i++)
            {
                horizontalLine += "-";
            }
        }


        public List<CreatureBaseAbstract> CreateCreatures()
        {
            for (int i = 0; i < 4; i++)
            {
                creatures.Add(cF.Create(Creatures.Goblin));
            }

            return creatures;
        }

        public void MoveCreatures(GameWorld world)
        {
            foreach (var c in creatures)
            {
                c.Move(world);
            }
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
