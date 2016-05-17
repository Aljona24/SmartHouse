using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IFactory
    {
        SwitchableDevise CreateHomeCinema(int levelBass, int levelBrightness, int levelSelectChannel, int levelSoundHighs, int levelVolume);
        SwitchableDevise CreateLighting(int levelBrightness);
        SwitchableDevise CreateMusicCenter(int levelBass, int levelSelectChannel, int levelSoundHighs, int levelVolume);
    }
}