using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleMenu.Show();
            Bass b = new Bass(10);
            Brightness bright = new Brightness();
            SelectChannel s = new SelectChannel();
            SoundHighs sh = new SoundHighs();
            Volume v = new Volume();
            SelectChannel sc = new SelectChannel();
        }
    }
}
