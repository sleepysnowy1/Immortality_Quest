
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
        //public List<Group> groups = new List<Group>();
        public IGroupEnemy Enemies { get; set; }
        public List<Item> RoomItems {  get; set; } 
        public bool Walkable { get;  }

        public bool Explored { get; set; }


        #endregion

        #region Constructors 
        public Tiles()
        {
            
            RoomItems = new List<Item>();
            Walkable = true;
            
            Enemies = new GroupEnemy();

            RoomItems = new List<Item>();
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
