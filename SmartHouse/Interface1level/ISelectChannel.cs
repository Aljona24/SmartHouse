using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface ISelectChannel
    {
        void Next();
        void Prev();
        void Go();
    }
}