using Immortality_Quest.Elements.Classes.Inventory_and_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public class Equipment
    {
        Armor? equipedArmor;

        Weapon? equipedWeapon;

        #region Methods 
        //public void EquipItem<T>(T Item, ref List<Item> inventory)
        //{
        //    if(typeof(T) is Armor)
        //    {
        //        //if the armor slot isn't empty then, add the armor back to the entity's inventory
        //        if(equipedArmor != null)
        //        {
        //            inventory.Add(equipedArmor);
        //        }

        //        equipedArmor = T; 

        //    }

        /// <summary>
        /// Takes in a valid item to be equiped along with a reference to the inventory it belongs to. 
        /// </summary>
        /// <param name="armor">Armor to be equiped.</param>
        /// <param name="inventory">Inventory the item belongs to.</param>
        public void EquipItem(Armor item, ref List<Item> inventory)
        {

            //if the armor slot isn't empty then, add the armor back to the entity's inventory
            if (equipedArmor != null)
            {
                inventory.Add(equipedArmor);
            }
            
                equipedArmor = item;
        }

        /// <summary>
        /// Takes in a valid item to be equiped along with a reference to the inventory it belongs to.
        /// </summary>
        /// <param name="weapon">Weapon to be equiped</param>
        /// <param name="inventory">Inventory the item belongs to.</param>
        public void EquipItem(Weapon weapon, ref List<Item> inventory)
        {

            //if the weapon slot isn't empty then, add the weapon back to the entity's inventory
            if (equipedArmor != null)
            {
                inventory.Add(equipedWeapon);
            }
            else
            {
                inventory.Remove(equipedArmor);
                equipedWeapon = weapon; 
            }
            
        }

        public void ShowEquippedWeapon()
        {

            if (equipedWeapon != null)
            {
                Console.WriteLine($"{equipedWeapon.ItemName}"); 
            }
            else
            {
                //TODO change this to something more intutive
                Console.WriteLine("There is no equiped weapon.");
            }
        }
        #endregion

    }

} 
    


