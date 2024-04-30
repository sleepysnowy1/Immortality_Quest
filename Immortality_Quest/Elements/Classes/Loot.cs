using Immortality_Quest.Elements.Classes.Inventory_and_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public static class Loot
    {
        #region Methods 
        /// <summary>
        /// Gives a tile to be looted along with the players inventory for the items to be added to.  
        /// </summary>
        /// <param name="lootedTile"></param>
        /// <param name="lootersInventory"></param>
        public static void GetLoot(Tiles lootedTile, List<Item> lootersInventory)
        {

            if (lootedTile.RoomItems.Count != 0) // make sure there are lootable items to begin with
            {
                foreach (var item in lootedTile.RoomItems) //add all lootable items in the room to players inventory. Show items as they are looted
                {
                    
                    //Console.WriteLine($"You obtained {item.ItemName}");

                    //ColorDisplay.Write(ConsoleColor.White, "You obtained", ConsoleColor.Blue, $"{item.ItemName}");
                    lootersInventory.Add(item);
                }
                Console.ReadLine();

                lootedTile.RoomItems = new List<Item>();
            }
            else
            {
                ColorDisplay.WriteLine(ConsoleColor.Red, "No loot here.");
                Console.ReadLine();
            }
            
        }

        #endregion
    }
}
