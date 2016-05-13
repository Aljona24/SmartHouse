using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Bass : IScale
    {
        int level;
        //int min;
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
        public Bass(int level)
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
