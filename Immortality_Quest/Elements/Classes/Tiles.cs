
using Immortality_Quest.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Classes;

using Immortality_Quest.Elements.Interfaces;
using Immortality_Quest.Elements.Classes.Inventory_and_items;

namespace Immortality_Quest.Elements.Classes
{
    public class Tiles
    {

        #region Properties
        public List<Group> groups = new List<Group>();

        public List<Item> RoomItems = new List<Item>();
        public bool Walkable { get;  } 


        #endregion

        #region Constructors 
        public Tiles(List<Group> groupsInTile, bool walkable)
        {
            Walkable = walkable;
            groups.AddRange(groupsInTile);
        }
        #endregion
        
        #region Methods 
        public bool TileWalkable()
        {
            return Walkable;
        }
        
        #endregion
    }
}
