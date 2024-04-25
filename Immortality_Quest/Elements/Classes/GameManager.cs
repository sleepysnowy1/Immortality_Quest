using System;
using System.Collections.Generic;
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
        public bool TryMove(Group.Directions direction)
        {
            bool canMoveThere;
            //determine if the tile is not walkable or out of bounds. Return false if true. 
            if (direction() >= gameMap && direction() <= gameMap && gameMap.TryGetTile(direction()).Walkable == false)
            {                                                   //^ TODO: adding OR operator here causes this statement to calculate as true.
                
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
        

        
        #endregion
    }
}
