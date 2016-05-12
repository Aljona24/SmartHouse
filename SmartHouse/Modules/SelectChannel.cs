using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class SelectChannel : ISwitchModule
    {
        public int CurrentChannel { get; set; }
        Dictionary<int, string> channels = new Dictionary<int, string>
        {
            {1, "1+1"}, {2, "Интер"}, {3, "СТБ"}, {4, "Украина"}, {5, "ICTV"}, {6, "Новый канал"},
        };
        public int Next()
        {
            if (CurrentChannel == channels.Keys.Max())
            {
                CurrentChannel = channels.Keys.Min();
            }
            else
            {
                CurrentChannel += 1;
            }
            return CurrentChannel;
        }
        public int Prev()
        {
            if (CurrentChannel == channels.Keys.Min())
            {
                CurrentChannel = channels.Keys.Max();
            }
            else
            {
                CurrentChannel -= 1;
            }
            return CurrentChannel;
        }

        public int Go(int whereToMove = 0)
        {
            CurrentChannel = whereToMove;
            return CurrentChannel;
        }
    }
}