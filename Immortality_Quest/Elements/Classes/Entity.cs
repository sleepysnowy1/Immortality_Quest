using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    internal class Entity
    {
        public decimal HP { get; set; }

        public decimal Mana { get; set; }

        public decimal Initiative { get; set; }

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
        #endregion
    }
}
