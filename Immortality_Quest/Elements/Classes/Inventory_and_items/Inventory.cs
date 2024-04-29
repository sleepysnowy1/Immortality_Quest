using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    /// <summary>
    /// A class which is used to store a player's group, or NPC's group items
    /// </summary>
    public class Inventory
    {
        #region Properties & Backing fields 
        List<Item> items;

        public virtual float InventoryWeightLB { get => _inventoryWeightLB; set => _inventoryWeightLB = value; }
        private float _inventoryWeightLB;
        public virtual float WeightLimit { get => _weightLimit; }
        private readonly float _weightLimit;
        #endregion

        #region Constructors 
        public Inventory(float weightLB, float weightLimit)
        {
            items = new List<Item>();
            _inventoryWeightLB = weightLB;
            _weightLimit = weightLimit;
        }
        public Inventory(List<Item> giveItems, float weightLB, float weightLimit)
        {
            items = new List<Item>();

            items.AddRange(giveItems);

            _inventoryWeightLB = weightLB;
            _weightLimit = weightLimit;
        }
        public Inventory()
        {
            items = new List<Item>();
            _inventoryWeightLB = 0;
            _weightLimit = 10;
        }
        #endregion

        #region Methods 

        public void CalculateTotalWeight()
        {
            float totalWeight = 0;

            foreach (var item in items)
            {
                totalWeight += item.WeightLB; 
            }

            
        }

        public void AddItem(Item newItem)
        {
            if(InventoryWeightLB + newItem.WeightLB <= WeightLimit)
            {
                items.Add(newItem);
                InventoryWeightLB += newItem.WeightLB;
            }
            else
            {
                {
                    ColorDisplay.WriteLine(ConsoleColor.Red, "Weight Exceeded"); 
                }
            }
        }

        public void ShowInventory()
        {
            int count = 1; 

            foreach (var item in items)
            {
                Console.WriteLine($"{count}: {item.ItemName}");

                count++; 
            }
        }
        #endregion
    }
}
