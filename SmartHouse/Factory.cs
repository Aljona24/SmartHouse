using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Factory : IFactory
    {
        public virtual SwitchableDevise Create(Devices device)
        {
            Bass bass = new Bass(10);
            Brightness brightness = new Brightness(20);
            SelectChannel selectChannel = new SelectChannel(1);
            SoundHighs soundHighs = new SoundHighs(12);
            Volume volume = new Volume(10);            
            switch (device)
            {
                case Devices.HomeCinema:
                    
                    return new HomeCinema(bass, brightness, soundHighs, volume, selectChannel);                    
                case Devices.Lighting:
                    return new Lighting(brightness);
                case Devices.MusicCenter:
                    return new MusicCenter(bass, soundHighs, volume, selectChannel);
                default:
                    return null;
            }
            
        }
    }
}