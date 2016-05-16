using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lighting : SwitchableDevise, IBrightness
    {
        public Scale Scale { get; set; }
        public Lighting(Scale Scale)
        {
            this.Scale = Scale;
        }
        public int Decrease()
        {
            return Scale.Increase();
        }
        public int Increase()
        {
            return Scale.Decrease();
        }
    }
}