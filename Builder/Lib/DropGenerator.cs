using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    class DropGenerator
    {
        private ItemBuilder itemBuilder;

        public DropGenerator(ItemBuilder ib)
        {
            itemBuilder = ib;
        }

        public Item GetItem()
        {
            return itemBuilder.GetItem();
        }

        public void MakeItem()
        {
            itemBuilder.BuildBase();
            itemBuilder.BuildName();
            itemBuilder.BuildRarity();
            itemBuilder.BuildDropRate();
        }
    }
}
