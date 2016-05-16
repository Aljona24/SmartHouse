using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ISwitch
    {
        int CurrentChannel { get; set; }
        int Next();
        int Prev();
        int Go(int whereToMove);
    }
}