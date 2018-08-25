using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    class UniqueItemBuilder : ItemBuilder
    {
        private Item item;

        public UniqueItemBuilder()
        {
            item = new Item();
        }

        public void BuildBase()
        {
            item.Base = "Random from helmet pauldron etc.";
        }

        public void BuildDropRate()
        {
            item.DropRate = "one percent";
        }

        public void BuildName()
        {
            item.Name = "kickass name chosen based on item base";
        }

        public void BuildRarity()
        {
            item.Rarity = "UNIQUE item";
        }

        public Item GetItem()
        {
            return item;
        }
    }
}
