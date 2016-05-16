using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class HomeCinema : SwitchableDevise, IBrightness, IVolume, IBass, ISoundHighs, ISelectChannel
    {
        public Scale Bass { get; set; }
        public Scale Brightness { get; set; }
        public Scale SoundHighs { get; set; }
        public Scale Volume { get; set; }
        public ISwitch SelectChannel { get; set; }
       
        public HomeCinema(Scale Bass, Scale Brightness, Scale SoundHighs, Scale Volume, ISwitch Switch)
        {
            this.Bass = Bass;
            this.Brightness = Brightness;
            this.SoundHighs = SoundHighs;
            this.Volume = Volume;
            this.SelectChannel = Switch;
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
        int IBrightness.Increase()
        {
            return Brightness.Increase();
        }
        int IBrightness.Decrease()
        {
            return Brightness.Decrease();
        }

        int IVolume.Increase()
        {
            return Volume.Increase();
        }

        int IVolume.Decrease()
        {
            return Volume.Decrease();
        }

        int IBass.Increase()
        {
            return Bass.Increase();
        }

        int IBass.Decrease()
        {
            return Bass.Decrease();
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