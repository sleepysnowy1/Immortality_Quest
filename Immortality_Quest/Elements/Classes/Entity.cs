using Immortality_Quest.Elements.Classes.Inventory_and_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public class Entity
    {
        #region Properties
        public decimal HP { get; set; }

        public decimal Mana { get; set; }

        public decimal Initiative { get; set; }

        public Equipment equipped = new Equipment();
        #endregion

        #region Constructors 
        public Entity(decimal HP, decimal Mana, decimal Initiative)
        {
            this.HP = HP;   
            this.Mana = Mana;
            this.Initiative = Initiative;
        }
        #endregion

        #region Methods 
        public bool CheckEntityDead() { return HP <= 0; }

        //public void EquipWeapon(Item item)
        //{

        //}
        #endregion
    }
}
