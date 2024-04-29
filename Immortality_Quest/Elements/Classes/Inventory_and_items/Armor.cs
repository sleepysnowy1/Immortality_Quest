using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    public class Armor : Combat
    {
        private int _armor = 0; 

        public virtual int ArmorPoints { get => _armor; set => _armor = value; }

        public virtual CombatMaterialMetal MetalType { get; set; }
    }
}
