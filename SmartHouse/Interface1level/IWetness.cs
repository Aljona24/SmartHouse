using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IWetness
    {
        void Increase();
        void Decrease();
    }
}