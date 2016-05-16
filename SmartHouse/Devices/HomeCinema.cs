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
        public ISwitch Switch { get; set; }
       
        public HomeCinema(Scale Bass, Scale Brightness, Scale SoundHighs, Scale Volume, ISwitch Switch)
        {
            this.Bass = Bass;
            this.Brightness = Brightness;
            this.SoundHighs = SoundHighs;
            this.Volume = Volume;
            this.Switch = Switch;
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
        int IBrightness.Increase()
        {
            return Brightness.Increase();
        }
        int IBrightness.Decrease()
        {
            return Brightness.Decrease();
        }
    }
}