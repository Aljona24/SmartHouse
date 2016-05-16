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
        public ISwitch SelectChannel { get; set; }

        public MusicCenter(Scale Bass,  Scale SoundHighs, Scale Volume, ISwitch Switch)
        {
            this.Bass = Bass;
            this.SoundHighs = SoundHighs;
            this.Volume = Volume;
            this.SelectChannel = Switch;
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
            return SelectChannel.Next();
        }

        public int Prev()
        {
            return SelectChannel.Prev();
        }

        public int Go(int whereToMove)
        {
            return SelectChannel.Go(whereToMove);
        }

        int IVolume.Increase()
        {
            return Volume.Increase();
        }

        int IVolume.Decrease()
        {
            return Volume.Decrease();
        }

        int ISoundHighs.Increase()
        {
            return SoundHighs.Increase();
        }

        int ISoundHighs.Decrease()
        {
            return SoundHighs.Decrease();
        }
    }
}