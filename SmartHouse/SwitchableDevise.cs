using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    abstract class SwitchableDevise
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
    }
}