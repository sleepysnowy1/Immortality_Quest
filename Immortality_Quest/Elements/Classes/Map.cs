using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Interfaces;


namespace Immortality_Quest.Elements.Classes
{
    public class Map 
    {
        private Tiles[,] _level; 

        private readonly int _x;

        private readonly int _y; 
        public int X { get => _x; }
        public int Y { get => _y; }
        
        public Tiles[,] Level { get => _level; set => _level = value; }

        public Map ()
        {
            _x = 10; 
            _y = 10;

            _level = new Tiles[_x, _y];
            
            GenerateMap(); 

        }

        /// <summary>
        /// This generates a new map. 
        /// </summary>
        public void GenerateMap()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            //Create a randomaized postion for the downstairs tile
            int downStairposX = rnd1.Next(1, X);
            int downStairposY = rnd2.Next(1, Y);

            //Loop through each row and column of 2D array, the map.
            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        Level[row, col] = new StaircaseEntranceTile();
                    }
                    else if (downStairposX == row && downStairposY == col) //use randomaized postition and insert at that posstion once loop rotates to that space. 
                    {
                        Level[row, col] = new StaircaseDownTile();
                        
                    }
                    else
                        Level[row, col] = new RockTile();

                }
            }
        }

        /// <summary>
        /// Simply print the genereted map with different symbols for each tile.
        /// </summary>
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
        public Tiles TryGetTile(int x, int y)
        {
            Tiles? tile = null;

            //TODO the the fact that X is used as an operrand on the right side for the less than condtions may cause incorrect logic and must be fixed
            if(x < this.X || y < this.Y || x > this.X || y < this.Y)
            {
                tile = Level[x, y];
            }
            return tile; 
            
        }
        public Tiles TryGetTile(Coordinate coord)
        {
            Tiles? tile = null;
            if (coord.X < this.X - 1 || coord.Y < this.Y - 1 || coord.X > this.X - 1|| coord.Y < this.Y - 1) //TODO: this statement allows user to go out of bound of array which causes excpetion
            {
                tile = Level[coord.X, coord.Y];
            }
            return tile;
        }
    }
}
