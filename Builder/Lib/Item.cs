using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    class Item : ItemPlan //concrete product
    {
        string itemBase, dropRate, itemName, rarity;

        public string Base
        {
            get
            {
                return itemBase;
            }

            set
            {
                itemBase = value;
            }
        }

        public string DropRate
        {
            get
            {
                return dropRate;
            }

            set
            {
                dropRate = value;
            }
        }

        public string Name
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string Rarity
        {
            get
            {
                return rarity;
            }

            set
            {
                rarity = value;
            }
        }



        //public void SetItemBase(string itemBase)
        //{
        //    this.ItemBase = itemBase;
        //}

        //public void SetItemDropRate(string dropRate)
        //{
        //    this.DropRate = dropRate;
        //}

        //public void SetItemName(string name)
        //{
        //    this.ItemName = name;
        //}

        //public void SetItemRarity(string rarity)
        //{
        //    this.Rarity = rarity;
        //}
    }
}
