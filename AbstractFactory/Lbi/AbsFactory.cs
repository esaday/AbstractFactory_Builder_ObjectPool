using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Lbi
{
   public abstract class ThemeFactory //abst fact.
    {
        public abstract ScrollBar CreateScrollBar();
        public abstract Slider CreateSlider();
    }

    public class LightTheme : ThemeFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new LightScrollBar();
        }

        public override Slider CreateSlider()
        {
            return new LightSlider();
        }
    }

    public class PurpleTheme : ThemeFactory
    {
        public override ScrollBar CreateScrollBar()
        {
            return new PrupleScrollBar();
        }

        public override Slider CreateSlider()
        {
            return new PurpleSlider();
        }
    }
}
