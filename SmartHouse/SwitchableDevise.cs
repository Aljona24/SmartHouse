using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class SwitchableDevise
    {
        public bool OnOff { get; set; }
        public virtual bool On()
        {
            return OnOff = true;
        }
        public virtual bool Off()
        {
            return OnOff = false;
        }
        public override string ToString()
        {
            return OnOff ? "On": "Off";
        }
    }
}