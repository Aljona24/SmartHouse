using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class MusicCenter : SwitchableDevise, IBass, IVolume, ISoundHighs, ISelectChannel
    {
        public Scale Bass { get; set; }
        public Scale SoundHighs { get; set; }
        public Scale Volume { get; set; }
        public ISwitch Switch { get; set; }

        public MusicCenter(Scale Bass,  Scale SoundHighs, Scale Volume, ISwitch Switch)
        {
            this.Bass = Bass;
            this.SoundHighs = SoundHighs;
            this.Volume = Volume;
            this.Switch = Switch;
        }
        int IBass.Increase()
        {
            return Bass.Increase();
        }
        int IBass.Decrease()
        {
            return Bass.Decrease();
        }

        public int Next()
        {
            return Switch.Next();
        }

        public int Prev()
        {
            return Switch.Prev();
        }

        public int Go(int whereToMove)
        {
            return Switch.Go(whereToMove);
        }
    }
}