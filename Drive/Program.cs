using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drive.Model;
using Drive.Repository;

namespace Drive
{
    class Program
    {
        static void Main(string[] args)
        {
            var carAutoRepository = new СarBenzRepository();
            var carAuto = new CarAutoRepository();

            bool choise = true;
            while (choise)
            {
                GetMenu();

                int.TryParse(Console.ReadLine(), out var command);
                if (command == 0)
                {
                    GetError();
                }

                switch (command)
                {
                    case 1:
                        Console.WriteLine("Введите модель автомобиля: ");
                        Console.WriteLine("Например: ");
                        var selectedBenzCar = from Car in carAutoRepository.cars
                                              select Car;
                        foreach (Car c in selectedBenzCar)
                            Console.WriteLine(c.name);

                        string NAME = Console.ReadLine();

                        var car = carAutoRepository.GetByName(NAME);
                        if (car == null)
                        {
                            Console.WriteLine("Такой модели не найдено");
                        }
                        else
                        {
                            car.GetCharacteristic();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите модель автомобиля: ");
                        Console.WriteLine("Например: ");
                        var selectedAutoCar = from Car in carAutoRepository.cars
                                              select Car;
                        foreach (Car c in selectedAutoCar)
                            Console.WriteLine(c.name);

                        string NAME1 = Console.ReadLine();

                        var cars = carAutoRepository.GetByName(NAME1);
                        if (cars == null)
                        {
                            Console.WriteLine("Такой модели не найдено");
                        }
                        else
                        {
                            cars.GetCharacteristic();
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        continue;
                    default:
                        Console.WriteLine("Такая команда не найдена. Повторите ввод");
                        break;
                }

            }




            Console.ReadKey();
        }

        ///<summary>
        ///Выводим меню
        ///</summary>
        public static void GetMenu()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("1. БензоКар\n2. ЭлектроКар\n3. Выход из программы");
            Console.WriteLine("Введите номер пункта: ");
            Console.ForegroundColor = color;
        }

        /// <summary>
        /// Текст ошибки при некорректном вводе.
        /// </summary>
        public static void GetError()
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Данные ввода некорректны. Повторите попытку");
            Console.ForegroundColor = color;
        }
    }
}
