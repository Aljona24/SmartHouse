using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class SelectChannel : ISwitch
    {
        public SelectChannel(int currentChannel)
        {
            CurrentChannel = currentChannel;
        }
        public int CurrentChannel { get; set; }
        Dictionary<int, string> channelsDb = new Dictionary<int, string>
        {
            {1, "1+1"}, {2, "Интер"}, {3, "СТБ"}, {4, "Украина"}, {5, "ICTV"}, {6, "Новый канал"},
        };
        public int Next()
        {
            if (CurrentChannel == channelsDb.Keys.Max())
            {
                CurrentChannel = channelsDb.Keys.Min();
            }
            else
            {
                CurrentChannel += 1;
            }
            return CurrentChannel;
        }
        public int Prev()
        {
            if (CurrentChannel == channelsDb.Keys.Min())
            {
                CurrentChannel = channelsDb.Keys.Max();
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
        public override string ToString()
        {
            return channelsDb[CurrentChannel];
        }
    }
}