using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lighting : SwitchableDevise, IBrightness
    {
        public Lighting(Scale scale)
        {
            this.Brightness = scale;
        }

        public Scale Brightness { get; set; }

        public int Decrease()
        {
            return Brightness.Increase();
        }
        public int Increase()
        {
            return Brightness.Decrease();
        }
    }
}