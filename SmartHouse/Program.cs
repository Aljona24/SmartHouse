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
            Factory factory1 = new Factory();
            ConsoleMenu cm = new ConsoleMenu(factory1);
            cm.Show();

        }
    }
}
