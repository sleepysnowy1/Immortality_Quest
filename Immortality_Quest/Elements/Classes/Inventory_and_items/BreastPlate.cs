using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    public class BreastPlate : Armor
    {

        #region Constructors 
        public BreastPlate()
        {
            Random randomArmorMatChance = new Random();

            //TODO refacor this code to make more extensible and less hardcoded 
            //find random armor material and give armor points based on that mat
            if (randomArmorMatChance.Next(1, 1000) <= 400)
            {
                MetalType = CombatMaterialMetal.Rusted_Iron;
                ArmorPoints += 1;
                
            }
            else if (randomArmorMatChance.Next(1, 1000) > 400 && randomArmorMatChance.Next(1, 1000) <= 700)
            {
                MetalType = CombatMaterialMetal.Steel;
                ArmorPoints += 2;
                
            }
            else if (randomArmorMatChance.Next(1, 1000) > 700 && (randomArmorMatChance.Next(1, 1000) <= 950))
            {
                MetalType = CombatMaterialMetal.Plasteel;
                ArmorPoints += 3;
                
            }
            else if (randomArmorMatChance.Next(1, 1000) > 950)
            {
                MetalType = CombatMaterialMetal.Black_Cobalt;
                ArmorPoints += 4;
                
            }

            ItemName = $"{MetalType} Breast Plate"; 

        }// end constructor 

        #endregion

        #region Methods 
        public override bool ItemInteraction(GameManager game)
        {
            string userInput = string.Empty;
            bool actionTaken = false;


            do
            {
                ColorDisplay.Write(ConsoleColor.Green, "E", ConsoleColor.White, "quip");
                ColorDisplay.Write(ConsoleColor.Green, " I", ConsoleColor.White, "nfo\n");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    //case "U":
                    //case "u":
                    //    UseItem();
                    //    return actionTaken = true;
                        

                    case "E":
                    case "e":
                    case "equip":
                    case "Equip": 
                        game.PlyrGrp.GetMember(game).equipped.EquipItem(this, ref game.PlyrGrp.groupInventory.items);
                        return actionTaken = true;

                    case "I":
                    case "i":
                    case "Info":
                    case "info":
                        ItemInfo(); 
                        return actionTaken = true;
                        

                    default:
                        actionTaken = false;
                        break;
                        
                }
            } while (actionTaken == false);

            return true;
        }

        public override void ItemInfo()
        {
            Console.WriteLine(ToString());
            Console.ReadLine();
        }
        public override string ToString()
        {
            return $"MetalType: {MetalType}, Armor: {ArmorPoints}"; 
        }
        #endregion
    }
}
