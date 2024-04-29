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
        }// end constructor 

        #endregion

        #region Methods 

        public override string ToString()
        {
            return $"Armor Points: {ArmorPoints}, MetalType: {MetalType}"; 
        }
        #endregion
    }
}
