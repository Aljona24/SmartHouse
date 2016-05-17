using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public abstract class Scale
    {
        private int level;//явно приват
        //int max; readonly+ конструктор
        //енум устройство и оставить его одного , каррент, мин, мах, стэп
        // buss volume убираются 
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
        public override string ToString()
        {
            return "Level " + Level;
        }
    }
}