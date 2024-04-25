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

        public GameManager()
        {
            PlyrGrp = new Group();
            gameMap = new Map();
        }

        #region Methods 
        public bool TryMoveNorth()
        {
            bool canMoveThere; 
            if(PlyrGrp.Loc.Y + 1 >= gameMap.Y && gameMap.TryGetTile(PlyrGrp.Loc.X, PlyrGrp.Loc.Y + 1).Walkable) 
            {
                return canMoveThere = true;
            }
            else
                return canMoveThere = false;
        }

        public bool TryMoveSouth()
        {
            bool canMoveThere;
            if (PlyrGrp.Loc.Y - 1 <= gameMap.Y && gameMap.TryGetTile(PlyrGrp.Loc.X, PlyrGrp.Loc.Y - 1).Walkable)
            {
                return canMoveThere = true;
            }
            else
                return canMoveThere = false;
        }

        public bool TryMoveWest()
        {
            bool canMoveThere;
            if (PlyrGrp.Loc.X + 1 >= gameMap.Y && gameMap.TryGetTile(PlyrGrp.Loc.X + 1, PlyrGrp.Loc.Y).Walkable)
            {
                return canMoveThere = true;
            }
            else
                return canMoveThere = false;
        }
        public bool TryMoveEast()
        {
            bool canMoveThere; 
            if(PlyrGrp.Loc.X - 1 )
        }

        
        #endregion
    }
}
