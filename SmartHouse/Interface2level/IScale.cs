using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IScale
    {
        int Increase();
        int Decrease();
    }
}