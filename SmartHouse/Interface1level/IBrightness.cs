using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IBrightness
    {
        int Increase(IScale s);
        int Decrease(IScale s);
    }
}