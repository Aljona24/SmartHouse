using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lighting : SwitchableDevise, IBrightness
    {
        public IScale Scale { get; set; }
        public ISwitch Switch { get; set; }
        public Lighting(IScale Scale, ISwitch Switch)
        {
            this.Scale = Scale;
            this.Switch = Switch;
        }
        int IBrightness.Decrease(IScale s)
        {
            return s.Increase();
        }

        int IBrightness.Increase(IScale s)
        {
            return s.Decrease();
        }
    }
}