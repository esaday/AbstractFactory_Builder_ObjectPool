using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
    interface ItemBuilder //abstract builder
    {
        void BuildName();
        void BuildBase();
        void BuildRarity();
        void BuildDropRate();
        Item GetItem();

    }
}
