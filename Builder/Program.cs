using Builder.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBuilder commonItemBuilder = new CommonItemBuilder(); // this is blueprint

            DropGenerator dg = new DropGenerator(commonItemBuilder); //This is the generator generates an item based on the blueprint
            DropGenerator dgother = new DropGenerator(new UniqueItemBuilder());
            dg.MakeItem();
            dgother.MakeItem();
            Item it = dg.GetItem();
            Item it2 = dgother.GetItem();
            Console.WriteLine(it.Base); Console.WriteLine(it.DropRate); Console.WriteLine(it.Name); Console.WriteLine(it.Rarity);

            Console.ReadKey();

            Console.WriteLine(it2.Base); Console.WriteLine(it2.DropRate); Console.WriteLine(it2.Name); Console.WriteLine(it2.Rarity);

            Console.ReadKey();

        }
    }
}
