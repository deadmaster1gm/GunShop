using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Menu
    {
        public static void MainMenu ()
        {
            Console.WriteLine("1.Добавить автомобиль \n2.Обслужить автомобиль\n3.Посмотреть список автомобилей\n4.Выход");
            string? point = Console.ReadLine();
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
    }
}