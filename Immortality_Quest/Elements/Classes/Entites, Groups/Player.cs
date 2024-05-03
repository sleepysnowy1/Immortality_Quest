using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Immortality_Quest.Elements.Classes.Inventory_and_items;
using Immortality_Quest.Elements.Interfaces;
namespace Immortality_Quest.Elements.Classes
{
    internal class Player : Entity
    {
        #region properties 
        
        #endregion

        #region Constructors 
        public Player() 
        {
            HP = 100;
        }

        #endregion

        #region Methods 

        //public override void Attack(Entity target)
        //{
        //    target.TakeDamage(equipped.equipedWeapon.damRange);
            
        //}

        //public override void TakeDamage(DamageRange damage)
        //{
        //    decimal damageTaken;

        //    damageTaken = Convert.ToDecimal(damage.CalculateDamange());

        //    HP -= damageTaken;
        //}
        public override string ToString()
        {
            return "Player";

        }
        #endregion
    }
}
