using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    internal static class Randomanizer
    {



        public static bool TrySwordRandomanizer(out Sword sword) //TODO Change name to be more precise. 
        {
            Random num = new Random();

            if (num.Next(1, 101) <= 25)
            {
                sword = new Sword();
                return true;
            }
            else
            {
                sword = null; 
                return false;
            }
                 
        }

        public static bool TryBreastPlateRandomanizer(out BreastPlate breastPlate)
        {
            Random num = new Random();

            if (num.Next(1, 101) <= 25)
            {
                breastPlate = new BreastPlate();
                return true;
            }
            else
            {
                breastPlate = null; 
                return false;
            }
               
        }
    }
}
