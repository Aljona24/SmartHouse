using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public class ConsoleMenu
    {
        IFactory factory;
        Dictionary<string, SwitchableDevise> SwitchableDevisesDB = new Dictionary<string, SwitchableDevise>();
        public ConsoleMenu(IFactory factory)
        {
            SwitchableDevisesDB.Add("homeCinema1", factory.Create(Devices.HomeCinema));
            SwitchableDevisesDB.Add("lighting1", factory.Create(Devices.Lighting));
            SwitchableDevisesDB.Add("musicCenter1", factory.Create(Devices.MusicCenter));
            this.factory = factory;
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
                foreach (KeyValuePair<string, SwitchableDevise> pair in SwitchableDevisesDB)
                {
                    Console.WriteLine("Name = {0}", pair.Key);
                    ShowCurrentState(pair.Value);
                    Console.WriteLine("");
                }
                Console.WriteLine();
                Console.WriteLine("Управление:");
                Console.WriteLine("");
                Console.WriteLine("* Для управления существующим девайсом введите команду EDIT и его имя");
                Console.WriteLine("* Добавить новый девайс - ADD, тип и имя нового девайса");
                Console.WriteLine("");
                Console.WriteLine("e - выйти");
                string[] comands = Console.ReadLine().ToString().Split(' ');
                switch (comands[0].ToLower())
                {
                    case "edit":
                        SwitchableDevise controlledDvise = SwitchableDevisesDB[comands[1]];
                        ControlMenu(controlledDvise, comands[1]);
                        break;
                    case "add":
                        Devices d;
                        if(Enum.TryParse<Devices>(comands[1], out d))
                        {
                            SwitchableDevisesDB.Add(comands[2], factory.Create(d));
                        }
                        else
                        {
                            MassageAboutError();
                        }
                        Console.WriteLine("Устройство " + comands[2].ToString() + " добавлено");
                        break;
                    case "e":
                        return;
                    default:
                        break;
                }
            }
        }

        

        private void ControlMenu(SwitchableDevise controlledDvise, string name)
        {            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Состояние:");
                ShowCurrentState(controlledDvise);
                Console.WriteLine("Управление");
                Console.WriteLine("Выберите и введите название нужной команды:");
                Console.WriteLine("");
                Console.WriteLine("On");
                Console.WriteLine("Off");
                Console.WriteLine("");
                if (controlledDvise is IBass)
                {
                    Console.WriteLine("Bass Increase");
                    Console.WriteLine("Bass Decrease");
                    Console.WriteLine("");
                }
                if (controlledDvise is IBrightness)
                {
                    Console.WriteLine("Brightness Increase");
                    Console.WriteLine("Brightness Decrease");
                    Console.WriteLine("");
                }
                if (controlledDvise is ISoundHighs)
                {
                    Console.WriteLine("SoundHighs Increase");
                    Console.WriteLine("SoundHighs Decrease");
                    Console.WriteLine("");
                }
                if (controlledDvise is IVolume)
                {
                    Console.WriteLine("Volume Increase");
                    Console.WriteLine("Volume Decrease");
                    Console.WriteLine("");
                }
                if (controlledDvise is ISelectChannel)
                {
                    Console.WriteLine("Channel Next");
                    Console.WriteLine("Channel Prev");
                    Console.WriteLine("Channel Go");
                    Console.WriteLine("");
                }
                Console.WriteLine("e - в предыдущее меню");
                string[] comands = Console.ReadLine().ToString().Split(' ');
                switch ((comands[0].ToLower()))
                {
                    case "on":
                        controlledDvise.On();
                        return;
                    case "off":
                        controlledDvise.Off();
                        return;
                    case "bass":
                        if (controlledDvise is IBass)
                        {
                            if (comands[1] == "Increase")
                            {
                                ((IBass)controlledDvise).Increase();
                            }
                            else if (comands[1] == "Decrease")
                            {
                                ((IBass)controlledDvise).Decrease();
                            }
                            else
                            {
                                ((IBass)controlledDvise).Bass.Level = Convert.ToInt32(comands[1]);
                            }
                        }
                        else
                        {
                            MassageAboutError();
                        }
                        return;
                    case "brightness":
                        if (controlledDvise is IBrightness)
                        {
                            if (comands[1] == "Increase")
                            {
                                ((IBrightness)controlledDvise).Increase();
                            }
                            else if (comands[1] == "Decrease")
                            {
                                ((IBrightness)controlledDvise).Decrease();
                            }
                            else
                            {
                                ((IBrightness)controlledDvise).Brightness.Level = Convert.ToInt32(comands[1]);
                            }
                        }
                        else
                        {
                            MassageAboutError();
                        }

                        return;
                    case "channel":
                        if (controlledDvise is ISelectChannel)
                        {
                            if (comands[1] == "Next")
                            {
                                ((ISelectChannel)controlledDvise).Next();
                            }
                            else if (comands[1] == "Prev")
                            {
                                ((ISelectChannel)controlledDvise).Prev();
                            }
                            else if (comands[1] == "Go")
                            {
                                ((ISelectChannel)controlledDvise).Go(Convert.ToInt32(comands[2]));                //////try
                            }
                        }
                        else
                        {
                            MassageAboutError();
                        }

                        return;
                    case "soundhighs":
                        if (controlledDvise is ISoundHighs)
                        {
                            if (comands[1] == "Increase")
                            {
                                ((ISoundHighs)controlledDvise).Increase();
                            }
                            else if (comands[1] == "Decrease")
                            {
                                ((ISoundHighs)controlledDvise).Decrease();
                            }
                            else
                            {
                                ((ISoundHighs)controlledDvise).SoundHighs.Level = Convert.ToInt32(comands[1]);
                            }
                        }
                        else
                        {
                            MassageAboutError();
                        }

                        return;
                    case "volume":
                        if (controlledDvise is IVolume)
                        {
                            if (comands[1] == "Increase")
                            {
                                ((IVolume)controlledDvise).Increase();
                            }
                            else if (comands[1] == "Decrease")
                            {
                                ((IVolume)controlledDvise).Decrease();
                            }
                            else
                            {
                                ((IVolume)controlledDvise).Volume.Level = Convert.ToInt32(comands[1]);
                            }
                        }
                        else
                        {
                            MassageAboutError();
                        }
                        return;
                    case "e":
                        return;
                    default:
                        break;
                }
            }
        }
        private static void ShowCurrentState(SwitchableDevise controlledDvise)
        {
            Console.WriteLine(" State " + controlledDvise.ToString());
            if (controlledDvise is IBass)
            {
                Console.WriteLine(" Bass " + ((IBass)controlledDvise).Bass.ToString());
            }
            if (controlledDvise is IBrightness)
            {
                Console.WriteLine(" Brightness " + ((IBrightness)controlledDvise).Brightness.ToString());
            }
            if (controlledDvise is ISelectChannel)
            {
                Console.WriteLine(" SelectChannel " + ((ISelectChannel)controlledDvise).SelectChannel.ToString());
            }
            if (controlledDvise is ISoundHighs)
            {
                Console.WriteLine(" SoundHighs " + ((ISoundHighs)controlledDvise).SoundHighs.ToString());
            }
            if (controlledDvise is IVolume)
            {
                Console.WriteLine(" Volume " + ((IVolume)controlledDvise).Volume.ToString());
            }
        }
        private static void MassageAboutError()
        {
            Console.WriteLine("Команда не верна. Попробуйте еще раз");
            Console.ReadKey();
        }
    }
}