using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Classes.Entities__Groups;
using Immortality_Quest.Elements.Classes.Inventory_and_items;
using Immortality_Quest.Elements.Interfaces;


namespace Immortality_Quest.Elements.Classes
{
    public class Map 
    {
        private Tile[,] _level; 

        
        private readonly int _x;

        private readonly int _y; 
        public int X { get => _x; }
        public int Y { get => _y; }
        
        public Tile[,] Level { get => _level; set => _level = value; }

        public Map (GameManager game)
        {
            game.PlayerMoved += TileExplored;
            _x = 10; 
            _y = 10;

            _level = new Tile[_x, _y];
            
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
                    {
                        Level[row, col] = new RockTile();

                        //randomize whether tile has items or enemies
                        if (Randomanizer.TrySwordRandomanizer(out Sword sword ))
                        {
                            Level[row, col].RoomItems.Add(sword);
                            //Level[row, col].RoomItems.Add(Randomanizer.TryBreastPlateRandomanizer()); 
                            
                        }

                        if (Randomanizer.TryBreastPlateRandomanizer(out BreastPlate breastplate))
                        {
                            Level[row, col].RoomItems.Add(breastplate);
                            //Level[row, col].RoomItems.Add(Randomanizer.TryBreastPlateRandomanizer()); 

                        }

                        if(Randomanizer.TryRustedGolemSpawn(out RustedGolem spawn))
                        {
                            Level[row, col].Enemies.Members.Add(spawn);
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Simply print the genereted map with different symbols for each tile.
        /// </summary>
        public void PrintMap(GameManager game)
        {


            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    if (row == game.PlyrGrp.Loc.X && col == game.PlyrGrp.Loc.Y)
                    {
                        Console.Write("@");
                    }
                    else if (Level[row, col] is RockTile)
                    { 
                        if(Level[row, col].Explored == true)
                        Console.Write("0");
                        else
                            Console.Write(" ");
                    }
                    else if (Level[row, col] is StaircaseDownTile)
                    {
                        if(Level[row, col].Explored == true)
                        Console.Write("<");
                        else
                            Console.Write(" ");
                    }
                    else if (Level[row, col] is StaircaseEntranceTile)
                    {
                        if (Level[row, col].Explored == true)
                            Console.Write(">");
                        else
                            Console.Write(" ");
                        
                            
                    }

                }
                Console.WriteLine();
            }

            
            
        }
        /// <summary>
        /// Gets the tile at the specified coordinates. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool TryGetTile(int x, int y, out Tile tile)
        {

            if (Level[x, y] is not null)
            {
                tile = Level[x, y];
                return true;
            }
            else
            {
                tile = null;
                return false;
            }

            
            //if(x <= 0 || y <= 0 || x > this.X - 1 || y > this.Y - 1)
            //{
                
            //}
            //return tile; 
            
        }
        /// <summary>
        /// Gets the tile at the specified coordinates.
        /// </summary>
        /// <param name="coord"></param>
        /// <returns></returns>
        public Tile GetTile(Coordinate coord)
        {
            Tile? tile = null;
            if (coord.X < this.X - 1 || coord.Y < this.Y - 1 || coord.X > this.X - 1|| coord.Y < this.Y - 1) //TODO: this statement allows user to go out of bound of array which causes excpetion
            {
                tile = Level[coord.X, coord.Y];
            }
            return tile;
        }

        public void TileExplored(Coordinate coord, GameManager game)
        {
            Level[coord.X, coord.Y].Explored = true;
        }
    }
}
