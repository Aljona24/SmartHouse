using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IVolume
    {
        int Increase(IScale s);
        int Decrease(IScale s);
    }
}