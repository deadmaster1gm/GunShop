using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("1.Добавить автомобиль\n2.Обслужить автомобиль\n3.Посмотреть список автомобилей\n4.Выход");
            string point = Console.ReadLine();
            switch (point)
            {
                case "1":
                    {
                        AddVehicle.Add();
                    }
                    break;
                case "2":
                    {
                        Workshop.VisitWorkshop();
                    }
                    break;
                case "3":
                    {
                        GetDataVehicles.GetData();
                    }
                    break;
                case "4":
                    {

                    }
                    break;

            }
        }

        public static void WorkshopMenu(ObjectVehicle vehicle)
        {
            Console.WriteLine("1.Переобуть колеса\n2.Помыть автомобиль на автоматической мойке");
            string point = Console.ReadLine();
            switch (point)
            {
                case "1":
                    {
                        Console.WriteLine("Введите тип колес: литые или штампованные");
                        vehicle.wheels = Console.ReadLine();
                        Console.WriteLine("Колеса переобуты!");
                        Console.ReadLine();
                        Menu.MainMenu();

                    }
                    break;
                case "2":
                    {
                        vehicle.carWash = "Чистый";
                        Console.WriteLine("Автомобиль вымыт!");
                        Console.ReadLine();
                        Menu.MainMenu();
                    }
                    break;
            }
        }
    }
}