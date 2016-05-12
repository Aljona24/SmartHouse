using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ILevel
    {
        void Increase();
        void Decrease();
    }
}