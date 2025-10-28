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
            Console.Write("Введите марку автомобиля: ");
            string? brand = Console.ReadLine();
            Console.Write("Введите модель автомобиля: ");
            string? model = Console.ReadLine();
            Console.Write("Введите год выпуска автомобиля: ");
            string? year = Console.ReadLine();
            Console.Write("Придумайте и введите цвет автомобиля: ");
            string? color = Console.ReadLine();
            Console.Write("Выберите и введите тип колес автомобиля (штампы или литые диски): ");
            string? wheels = Console.ReadLine();
            Console.Write("Определите и введите чистый доставят автомобиль или же он сойдет с автовоза грязным (чистый или грязный): ");
            string? carWash = Console.ReadLine();

            ObjectVehicle vehicle = new (brand, model, year, color, wheels, carWash);
            Program.vehicles.Add(vehicle);
            Console.WriteLine("\nАвтомобиль добавлен в автосалон!");
            Menu.MainMenu();
        }

    }
}
