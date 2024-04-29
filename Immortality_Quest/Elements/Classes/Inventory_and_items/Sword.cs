using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    public class Sword : Weapon
    {

        public  CombatMaterialMetal Blade { get; init; }

        public CombatMaterialMetal Hilt { get; init; } 

        public CombatMaterialMetal Handle { get; init;  }

        

        #region Constructors 
        //Randomize sword makeup on parameterless object intialization 
        public Sword() : base()
        {
            //TODO: refactor this code to make more extensible and less hard coded
            //Could tie damange values directly to the enum. Or try another refacoring 

            Random randomBladeChance = new Random();


            //find random blade material 
            if (randomBladeChance.Next(1, 1000) <= 400)
            {
                Blade = CombatMaterialMetal.Rusted_Iron;
                damRange.MinDamage += 1;
                damRange.MaxDamage += 2;
            }
            else if (randomBladeChance.Next(1, 1000) > 400 && randomBladeChance.Next(1, 1000) <= 700)
            {
                Blade = CombatMaterialMetal.Steel;
                damRange.MinDamage += 2;
                damRange.MaxDamage += 3;
            }
            else if(randomBladeChance.Next(1,1000) > 700 && (randomBladeChance.Next(1, 1000) <= 950))
            {
                Blade = CombatMaterialMetal.Plasteel;
                damRange.MinDamage += 3;
                damRange.MaxDamage += 4; 
            }
            else if(randomBladeChance.Next(1, 1000) > 950)
            {
                Blade = CombatMaterialMetal.Black_Cobalt;
                damRange.MinDamage += 4;
                damRange.MaxDamage += 5; 
            }

            Random randomHiltChance = new Random(); 

            //find random hilt mat
            if (randomHiltChance.Next(1, 1000) <= 400)
            {
                Hilt = CombatMaterialMetal.Rusted_Iron;
                damRange.MinDamage += 1;
                damRange.MaxDamage += 2;
            }
            else if (randomHiltChance.Next(1, 1000) > 400 && randomHiltChance.Next(1, 1000) <= 700)
            {
                Hilt = CombatMaterialMetal.Steel;
                damRange.MinDamage += 2;
                damRange.MaxDamage += 3;
            }
            else if (randomHiltChance.Next(1, 1000) > 700 && (randomHiltChance.Next(1, 1000) <= 950))
            {
                Hilt = CombatMaterialMetal.Plasteel;
                damRange.MinDamage += 3;
                damRange.MaxDamage += 4;
            }
            else if (randomHiltChance.Next(1, 1000) > 950)
            {
                Hilt = CombatMaterialMetal.Black_Cobalt;
                damRange.MinDamage += 4;
                damRange.MaxDamage += 5;
            }

            Random randomHandleChance = new Random();
            //get random handle type 
            if (randomHandleChance.Next(1, 1000) <= 400)
            {
                Handle = CombatMaterialMetal.Rusted_Iron;
                damRange.MinDamage += 1;
                damRange.MaxDamage += 2; 
            }
            else if (randomHandleChance.Next(1, 1000) > 400 && randomHandleChance.Next(1, 1000) <= 700)
            {
                Handle = CombatMaterialMetal.Steel;
                damRange.MinDamage += 2;
                damRange.MaxDamage += 3;
            }
            else if (randomHandleChance.Next(1, 1000) > 700 && (randomHandleChance.Next(1, 1000) <= 950))
            {
                Handle = CombatMaterialMetal.Plasteel;
                damRange.MinDamage += 3;
                damRange.MaxDamage += 4;
            }
            else if (randomHandleChance.Next(1, 1000) > 950)
            {
                Handle = CombatMaterialMetal.Black_Cobalt;
                damRange.MinDamage += 4;
                damRange.MaxDamage += 5;
            }

            //set name of sword

            ItemName = $"{Blade} Sword"; 

        }//end constructor 
        #endregion

        #region Methods 
        public override string ToString()
        {
            return $"Blade is {Blade}, Hilt is {Hilt}, Handle is {Handle}, Min damange {damRange.MinDamage}, Max damage {damRange.MaxDamage}"; 
            
        }
        #endregion
    }
}
