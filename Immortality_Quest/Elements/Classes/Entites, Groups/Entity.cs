using Immortality_Quest.Elements.Classes.Inventory_and_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes
{
    public abstract class Entity
    {
        #region Properties
        public decimal HP { get; set; }

        public decimal Mana { get; set; }

        public decimal Initiative { get; set; }

        public Equipment equipped = new Equipment();
        #endregion

        #region Constructors 
        //public Entity(decimal HP, decimal Mana, decimal Initiative)
        //{
        //    this.HP = HP;   
        //    this.Mana = Mana;
        //    this.Initiative = Initiative;
        //}
        #endregion

        #region Methods 
        public bool CheckEntityDead() { return HP <= 0; }
        public abstract void Attack(Entity target);

        public abstract void TakeDamage(DamageRange damage);
        public void CheckEntityStatus()
        {
            ColorDisplay.Write(ConsoleColor.Red, $"HP: ", ConsoleColor.White, $"{HP}");
        }

        public void CheckEntityStatus(int count)
        {
            ColorDisplay.Write(ConsoleColor.White, $"{count}: {ToString()} ", ConsoleColor.Red, $"HP: ", ConsoleColor.White, $"{HP} \n");
        }
        //public abstract void Attack(Entity target);

        //public void EquipWeapon(Item item)
        //{

        //}
        #endregion
    }
}
