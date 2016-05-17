using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class Factory : IFactory
    {
        public SwitchableDevise CreateHomeCinema(int levelBass, int levelBrightness, int levelSelectChannel, int levelSoundHighs, int levelVolume)
        {
            Bass bass = new Bass(levelBass);
            Brightness brightness = new Brightness(levelBrightness);
            SelectChannel selectChannel = new SelectChannel(levelSelectChannel);
            SoundHighs soundHighs = new SoundHighs(levelSoundHighs);
            Volume volume = new Volume(levelVolume);
            return new HomeCinema(bass, brightness, soundHighs, volume, selectChannel);
        }
        public SwitchableDevise CreateLighting(int levelBrightness)
        {
            Brightness brightness = new Brightness(levelBrightness);
            return new Lighting(brightness);

        }
        public SwitchableDevise CreateMusicCenter(int levelBass, int levelSelectChannel, int levelSoundHighs, int levelVolume)
        {
            Bass bass = new Bass(levelBass);
            SelectChannel selectChannel = new SelectChannel(levelSelectChannel);
            SoundHighs soundHighs = new SoundHighs(levelSoundHighs);
            Volume volume = new Volume(levelVolume);
            return new MusicCenter(bass, soundHighs, volume, selectChannel);
        }
    }
}