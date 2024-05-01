using Immortality_Quest.Elements.Classes.Inventory_and_items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Entities__Groups
{
    internal class RustedGolem : Enemy
    {

        #region Properties 
        public DamageRange Damage { get; set; }
        #endregion

        #region Constructors 
        public RustedGolem()
        {
            HP = 25; 
            Mana = 25;
            Damage = new DamageRange(1, 5);
        }
        #endregion
        public override void Attack(Entity target)
        {
            target.TakeDamage(Damage);
        }
        public override void TakeDamage(DamageRange damage)
        {
            decimal damageTaken;

            damageTaken = Convert.ToDecimal(damage.CalculateDamange());

            HP -= damageTaken;
        }
        public override string ToString()
        {
            return "Rusted Golem";
        }

    }
}
