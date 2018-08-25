using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectPool.Lib;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Kahveci kahveci = new Kahveci();
            kahveci.KagitIste();
            kahveci.Uyar();
            kahveci.HesabiIste();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            Kahveci digerKahveci = new Kahveci();
            kahveci.KagitIste();
            kahveci.Uyar();
            kahveci.HesabiIste();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }
    }
}
