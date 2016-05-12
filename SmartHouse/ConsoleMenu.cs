using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public static class ConsoleMenu
    {
        public static void Show()
        {            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в Умный Дом");
                Console.WriteLine();
                Console.WriteLine("Выберите для управление нужный девайс:");

                Console.WriteLine("CC - ClimateControl");
                Console.WriteLine("HC - HomeCinema");
                Console.WriteLine("L - Lighting");
                Console.WriteLine("MC - MusicCenter");
                Console.WriteLine("B - Bathrom");

                Console.WriteLine("e - выйти");
                Console.WriteLine("");
                switch (Console.ReadLine().ToString().ToLower())
                {
                    case "cc":
                        ControlMenu(Devices.ClimateControl);
                        break;
                    case "hc":
                        ControlMenu(Devices.HomeCinema);
                        break;
                    case "l":
                        ControlMenu(Devices.Lighting);
                        break;
                    case "mc":
                        ControlMenu(Devices.MusicCenter);
                        break;
                    case "b":
                        ControlMenu(Devices.Buthroom);
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
        private static void ControlMenu(Devices devices)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Управление");
                Console.WriteLine();
                Console.WriteLine("Текущие состояние девайсов:");

                // текущие девайсы и состояние
                Console.WriteLine("del - удалить");
                Console.WriteLine("add - добавить");
                Console.WriteLine("edit - редактировать");
                Console.WriteLine("");
                Console.WriteLine("e - в предыдущее меню");
                switch (Console.ReadLine().ToString().ToLower())
                {
                    case "del":
                        Del();
                        break;
                    case "add":
                        Add();
                        break;
                    case "edit":
                        ();
                        break;
                        break;
                    case "e":
                        Show();
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }

        }

    }
}