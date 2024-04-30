using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public class GameManager
    {
        internal Group PlyrGrp { get; set; }
        internal Map gameMap { get; set; }

        public delegate Coordinate Directions(); 
        public GameManager()
        {
            PlyrGrp = new Group();
            
            gameMap = new Map();
        }

        #region Methods 
        /// <summary>
        /// Provides the logic for whether a group can move in a specified direction
        /// </summary>
        /// <param name="direction">Takes in a method which gives the direction to move in. Returns the X and Y postions as a Coordinate struct</param>
        /// <returns></returns>
        public bool TryMove(Group.Directions direction)
        {
            
            bool canMoveThere;
            //determine if the tile is not walkable or out of bounds. Return false if true. //direction() = delegate which represets inserted method which takes player postition and moves in specified direction.
            if (direction().X > gameMap.X - 1 || direction().X < 0 || direction().Y < 0 || direction().Y > gameMap.Y - 1 || gameMap.TryGetTile(direction()).Walkable == false) 
            {                                                   
                canMoveThere = false; //cant move there!
                return canMoveThere;
            }
            else //otherwise, the tile is not out of bounds and is walkable so return true
            {
                PlyrGrp.Loc = direction(); //update player location
                Console.WriteLine(PlyrGrp.Loc.ToString());
                return canMoveThere = true;
            }
        }

        public void ShowActions(GameManager game)
        {
            string userInput; 
            ColorDisplay.WriteLine(ConsoleColor.Green, " I", ConsoleColor.White, "ventory", ConsoleColor.Green, "L", ConsoleColor.White, "oot");
            Tiles tile;
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "n": case "N":
                case "s": case "S":
                case "w":
                case "W":
                case "e":
                case "E": 

                    game.TryMove(GameUtility.GetDirection(userInput, game.PlyrGrp));
                    break;

                case "I": case "i":
                    game.PlyrGrp.groupInventory.ShowInventory(game); 
                    break;

                case "L": case "l":
                     
                    Loot.GetLoot(PlyrGrp.GetTileAtCurrentLoc(game), PlyrGrp.groupInventory.items); 

                    break; 
            }

        }
        

        
        #endregion
    }
}
