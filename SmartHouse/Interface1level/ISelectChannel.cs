using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ISelectChannel
    {
        int Next(ISwitch sw);
        int Prev(ISwitch sw);
        int Go(ISwitch sw, int whereToMove);
    }
}