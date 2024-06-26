﻿using System;
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
        public List<Item> items;

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

        public bool TryAddItem(Item newItem)
        {
            bool couldAddItem; 

            if(InventoryWeightLB + newItem.WeightLB <= WeightLimit) // if adding the new item doesn't exceed carry weight, add item
            {
                items.Add(newItem);
                InventoryWeightLB += newItem.WeightLB;

                couldAddItem = true;
                return couldAddItem;
            }
            else //otherwise tell player weight is exceeded.
            {
                {
                    ColorDisplay.WriteLine(ConsoleColor.Red, "Weight Exceeded"); 
                    couldAddItem = false;
                    return couldAddItem;
                }
            }
        }

        public void AccessInventory(GameManager game)
        {
            int count = 1;
            string userInputString = string.Empty;
            
            bool actionTaken = false;

            do
            {
                Console.Clear();
                game.gameMap.PrintMap(game);
                GameUI.DisplayMovableDirections(game.PlyrGrp, game.gameMap);

                if (items.Count == 0) //if inventory is empty, tell the player. 
                {

                    do
                    {
                        ColorDisplay.WriteLine(ConsoleColor.White, "Inventory is", ConsoleColor.Red, "empty...");
                        ColorDisplay.WriteLine(ConsoleColor.Green, "B", ConsoleColor.White, "ack");
                        userInputString = Console.ReadLine();

                    } while (userInputString != "b" && userInputString != "B");

                    break; 
                }
                else //otherwise display inventory with index
                {


                    do
                    {
                        //show items for selection
                        count = 1;
                        foreach (var item in items)
                        {
                            Console.WriteLine($"{count}: {item.ItemName}");


                            count++;
                        }

                        //get item
                        Console.Write("Select item: "); ColorDisplay.WriteLine(ConsoleColor.Green, "B",
                                                                                     ConsoleColor.White, "ack");
                        userInputString = Console.ReadLine();

                        //TODO change output to use out instead and use regular while loop to test whether to continue loop after returning bool
                        try
                        {
                            actionTaken = items[Convert.ToInt32(userInputString) - 1].ItemInteraction(game); 
                        }
                        catch (Exception ex)
                        {
                             
                            actionTaken = false;
                            if (userInputString != "b" && userInputString != "B")
                            { 
                                ColorDisplay.WriteLine(ConsoleColor.Red, "That does nothing.");
                                Console.ReadLine(); 
                            }

                        }

                        Console.Clear();


                    } while (userInputString != "b" && userInputString != "B" && actionTaken == false);
                     
                } 

                

            } while (userInputString != "b" && userInputString != "B");
        }
        #endregion
    }
}
