using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class HomeCinema : SwitchableDevise, IBrightness, IVolume, IBass, ISoundHighs, ISelectChannel
    {
        public IScale Bass { get; set; }
        public IScale Brightness { get; set; }
        public IScale SoundHighs { get; set; }
        public IScale Volume { get; set; }
        public ISwitch Switch { get; set; }
       
        public HomeCinema(IScale Bass, IScale Brightness, IScale SoundHighs, IScale Volume, ISwitch Switch)
        {
            this.Bass = Bass;
            this.Brightness = Brightness;
            this.SoundHighs = SoundHighs;
            this.Volume = Volume;
            this.Switch = Switch;
        }        
        public int Increase(IScale s)
        {
            return s.Increase();
        }
        public int Decrease(IScale s)
        {
            return s.Decrease();
        }

        public int Next(ISwitch sw)
        {
            return sw.Next();
        }

        public int Prev(ISwitch sw)
        {
            return sw.Prev();
        }

        public int Go(ISwitch sw, int whereToMove)
        {
            return sw.Go(whereToMove);
        }
    }
}