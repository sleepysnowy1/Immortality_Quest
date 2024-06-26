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
        public virtual ItemRarity ItemRarity { get => _itemRarity; init => _itemRarity = value; }

        private readonly float _weightLB; 
        public virtual float WeightLB { get => _weightLB; }

        public virtual string ItemName { get; init; }
        #endregion


        //TODO add in rarity later 
        #region Constructors 
        

        #endregion

        #region Methods 
        public virtual void UseItem()
        {

        }

        public abstract void ItemInfo();
        public abstract bool ItemInteraction(GameManager game);
        
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
