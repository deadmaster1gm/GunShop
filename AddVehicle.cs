using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class AddVehicle
    {
        public static void Add()
        {
            ObjectVehicle vehicle = new();

            Console.Write("Введите марку автомобиля: ");
            vehicle.brand = Console.ReadLine();
            Console.Write("Введите модель автомобиля: ");
            vehicle.model = Console.ReadLine();
            Console.Write("Введите год выпуска автомобиля: ");
            vehicle.year = Console.ReadLine();
            Console.Write("Придумайте и введите цвет автомобиля: ");
            vehicle.color = Console.ReadLine();
            Console.Write("Выберите и введите тип колес автомобиля (штампы или литые диски): ");
            vehicle.wheels = Console.ReadLine();
            Console.Write("Определите и введите чистый доставят автомобиль или же он сойдет с автовоза грязным (чистый или грязный): ");
            vehicle.carWash = Console.ReadLine();

            ListVehicles.AddVehicle(vehicle);
            Console.WriteLine("\nАвтомобиль добавлен в автосалон!");
            Menu.MainMenu();
        }

    }
}
