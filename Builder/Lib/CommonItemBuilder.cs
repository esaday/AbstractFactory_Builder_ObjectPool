using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    class CommonItemBuilder : ItemBuilder //concrete builder
    {
        private Item item;

        public CommonItemBuilder()
        {
            item = new Item();
        } 

        public void BuildBase()
        {
            item.Base = "Random from helmet pauldron etc.";
        }

        public void BuildDropRate()
        {
            item.DropRate = "fifty percent";
        }

        public void BuildName()
        {
            item.Name = "name chosen based on item base";
        }

        public void BuildRarity()
        {
            item.Rarity = "common item";
        }

        public Item GetItem()
        {
            return item;
        }
    }
}
