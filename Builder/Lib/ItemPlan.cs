using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Lib
{
   public interface ItemPlan //abstract product
    {
        string Name { get; set; }
        string Base { get; set; }
        string Rarity { get; set; }
        string DropRate { get; set; }

    }
}
