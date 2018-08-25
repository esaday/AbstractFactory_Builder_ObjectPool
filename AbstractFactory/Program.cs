using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Lbi;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ThemeFactory tf = new PurpleTheme();
            tf.CreateScrollBar().Scroll();
            tf.CreateSlider().Slide();
            Console.ReadKey();

            ThemeFactory tf22 = new LightTheme();
            tf22.CreateScrollBar().Scroll();
            tf22.CreateSlider().Slide();
            Console.ReadKey();

        }
    }
}
