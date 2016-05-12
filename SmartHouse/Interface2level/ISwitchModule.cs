using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ISwitchModule
    {
        int Next();
        int Prev();
        int Go(int whereToMove = 0);
    }
}