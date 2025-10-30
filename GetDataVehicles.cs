using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicle
{
    public class GetDataVehicles
    {
        public static void GetData ()
        {
            foreach (ObjectVehicle vehicle in ListVehicles.vehicles)
            {
                Console.WriteLine
                   ($" Марка: {vehicle.brand}\n " +
                    $"Модель: {vehicle.model}\n " +
                    $"Год выпуска: {vehicle.year}\n " +
                    $"Цвет: {vehicle.color}\n " +
                    $"Колеса: {vehicle.wheels}\n " +
                    $"Чистота: {vehicle.carWash}\n");
            }
            Console.ReadLine();
            Menu.MainMenu();
        }
    }
}
