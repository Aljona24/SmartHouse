using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class ConsoleMenu
    {
        IFactory factory;
        // dictonary SwitchableDevise потом добавлять сюда
        //SwitchableDevise homeCinema1;
        //SwitchableDevise lighting1;
        //SwitchableDevise musicCenter1;
        public ConsoleMenu(IFactory factory)
        {
            this.factory = factory;
            this.homeCinema1 = factory.CreateHomeCinema();
            this.lighting1 = factory.CreateLighting();
            this.musicCenter1 = factory.CreateMusicCenter();
        }        
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в Умный Дом");
                Console.WriteLine();

                Console.WriteLine("Ваши девайсы:");
                Console.WriteLine();

                Console.WriteLine("Выберите для управление нужный девайс:");
                

                Console.WriteLine("e - выйти");
                Console.WriteLine("");
                switch (Console.ReadLine().ToString().ToLower())
                {
                    case "cc":
                        //ControlMenu();
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }
        private void ControlMenu(Devices devices)
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
                    //case "del":
                    //    Del();
                    //    break;
                    //case "add":
                    //    Add();
                    //    break;
                    //case "edit":
                    //    ();
                    //    break;
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