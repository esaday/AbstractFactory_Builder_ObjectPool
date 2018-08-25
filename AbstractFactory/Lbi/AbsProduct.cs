using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Lbi
{
    #region prod1
    public abstract class ScrollBar //abstract product
    {
        protected string color;

        public abstract string Color { get; set; }

        public abstract void Scroll();

    }

    public class LightScrollBar : ScrollBar //concrete product1
    {
        public override string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = "White";
            }
        }

        public override void Scroll()
        {
            Color = "";
            Console.WriteLine("Every day im scrolling in whitee!!");
        }
    }

    public class PrupleScrollBar : ScrollBar //concrete product2
    {
        public override string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public override void Scroll()
        {
            Console.WriteLine("Every day im scrolling in purpleee!!");
        }
    }

    #endregion

    #region prod2
    public abstract class Slider //abstract product
    {
        protected string color;
        protected string generalText;

        public abstract string Color
        {
            get; set;
        }

        public abstract string GeneralText
        {
            get; set;
        }

        public abstract void Slide();

    }

    public class LightSlider : Slider //concrete product
    {
        public override string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public override string GeneralText
        {
            get
            {
                return generalText;
            }

            set
            {
                generalText = "trololo";
            }
        }

        public override void Slide()
        {
            GeneralText = "h"; // still trololo
            Console.WriteLine("I'm sliding With" + GeneralText);
        }
    }

    public class PurpleSlider : Slider //concrete product
    {
        public override string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public override string GeneralText
        {
            get
            {
                return "puprpletrololoeoeloe";
            }

            set
            {
                generalText = value;
            }
        }

        public override void Slide()
        {
            Console.WriteLine("I'm sliding with " + GeneralText + " instead. YAY");
        }
    }
    #endregion
}
