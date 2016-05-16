using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lighting : SwitchableDevise, IBrightness
    {
        public Scale Brightness { get; set; }
        public Lighting(Scale Scale)
        {
            this.Brightness = Scale;
        }
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