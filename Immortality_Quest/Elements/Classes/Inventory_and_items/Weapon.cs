﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    public abstract class Weapon : CombatItem
    {
        #region Properties & Backing fields 
        public DamageRange damRange;
        #endregion

        #region Constructors 
        public Weapon() 
        {

        }
        #endregion
    }

    public struct DamageRange
    {
        #region Properties
        private int _minDamage;
        public int MinDamage { get => _minDamage; set => _minDamage = value; }

        private int _maxDamage;
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }
        #endregion

        #region Constructors 
        public DamageRange(int minDamage, int maxDamage)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        #endregion

        public int CalculateDamange()
        {
            Random rndN = new Random();

            return (int)rndN.Next(MinDamage, MaxDamage);
        }

        //public DamageRange GetDamageRange()
        //{
            
        //}
    } 

    
    

    
}
