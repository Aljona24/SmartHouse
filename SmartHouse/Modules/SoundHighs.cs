using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class SoundHighs : IScale
    {
        int level;
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
        public SoundHighs(int level)
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