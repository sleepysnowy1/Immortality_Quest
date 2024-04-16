using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Interfaces;
using Immortality_Quest.Elements.Struct;

namespace Immortality_Quest.Elements.Classes
{
    internal class Map : IMap
    {

        public readonly int _x;

        public readonly int _y; 
        public int X { get; }
        public int Y { get; }
        
        public Tiles[,] Level { get; set; }

        public Map ()
        {

        }

        public void GenerateMap()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        Level[row, col] = new StaircaseEntranceTile();
                    }
                    else if (rnd1.Next(0, 8) == row && rnd2.Next(0, 8) == col)
                    {
                        Level[row, col] = new StaircaseDownTile();
                    }
                    else
                        Level[row, col] = new RockTile();

                }
            }
        }


        public void PrintMap()
        {
            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    if (Level[row, col] is RockTile)
                    {
                        Console.Write("0");
                    }
                    else if (Level[row, col] is StaircaseDownTile)
                    {
                        Console.Write("<");
                    }
                    else if (Level[row, col] is StaircaseEntranceTile)
                    {
                        Console.Write(">");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
