using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Scale
    {
        int level;
        //int min; readonly+ конструктор
        //int max;

        public int Level
        {
            get { return level; }
            set
            {
                if (100 >= value && value >= 0)
                {
                    level = value;
                }
            }
        }
        public Scale(int level)
        {
            Level = level;
        }

        public int Decrease()
        {
            return --Level;
        }
        public int Increase()
        {
            return ++Level;
        }
    }
}