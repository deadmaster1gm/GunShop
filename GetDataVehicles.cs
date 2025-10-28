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
            foreach (ObjectVehicle vehicle in Program.vehicles)
            {
                Console.WriteLine
                   ($"Марка: {vehicle.Brand} " +
                    $"Модель: {vehicle.Model} " +
                    $"Год выпуска: {vehicle.Year} " +
                    $"Цвет: {vehicle.Color} " +
                    $"Колеса: {vehicle.Wheels} " +
                    $"Чистота: {vehicle.CarWash}");
            }
        }
    }
}
