﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IFactory
    {
        SwitchableDevise Create(Devices device);
        //SwitchableDevise Delete();
    }
}