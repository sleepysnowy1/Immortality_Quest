﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immortality_Quest.Elements.Classes.Inventory_and_items
{
    public abstract class Item
    {
        #region Properties & Backing Fields 
        private readonly ItemRarity _itemRarity;
        ItemRarity ItemRarity { get => _itemRarity; }

        private readonly float _weightLB; 
        public float WeightLB { get => _weightLB; }
        #endregion

        #region Constructors 
        //public Item(ItemRarity itemRarity, float weightLB)
        //{
        //    _itemRarity = itemRarity;
        //    _weightLB = weightLB;
        //}
        
        #endregion

        #region Methods 
        public virtual void UseItem()
        {

        }
        #endregion
    }

    public enum ItemRarity
    {
        Common,
        Uncommon,
        Rare,
        Expectional,
        Legendary
    }
}