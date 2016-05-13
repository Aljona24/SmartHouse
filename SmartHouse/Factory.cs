using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Factory : IFactory
    {
        public virtual SwitchableDevise CreateHomeCinema()
        {
            Bass bass = new Bass(10);
            Brightness brightness = new Brightness(20);
            SelectChannel selectChannel = new SelectChannel();
            SoundHighs soundHighs = new SoundHighs(12);
            Volume volume = new Volume(10);
            return new HomeCinema(bass, brightness, soundHighs, volume, selectChannel);
        }
        public virtual SwitchableDevise CreateLighting()
        {
            Brightness brightness = new Brightness(20);
            return new Lighting(brightness);
        }
        public virtual SwitchableDevise CreateMusicCenter()
        {
            Bass bass = new Bass(10);
            SelectChannel selectChannel = new SelectChannel();
            SoundHighs soundHighs = new SoundHighs(12);
            Volume volume = new Volume(10);
            return new MusicCenter(bass, soundHighs, volume, selectChannel);
        }
    }

}