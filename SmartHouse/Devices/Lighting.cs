using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Lighting : SwitchableDevise, IBrightness
    {
        public IScale Scale { get; set; }
        public Lighting(IScale Scale)
        {
            this.Scale = Scale;
        }
        public int Decrease(IScale s)
        {
            return s.Increase();
        }

        public int Increase(IScale s)
        {
            return s.Decrease();
        }
    }
}