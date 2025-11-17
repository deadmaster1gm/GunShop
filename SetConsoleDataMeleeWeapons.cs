using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class SetConsoleDataMeleeWeapons : IDataProvider
    {
        public Weapon GetData(Weapon weapon, string titleLine)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine($"Введите модель {titleLine}:\n");
                string? input = Console.ReadLine();

                if (input == "")
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    weapon.Model = input;
                    Console.Clear();
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine($"\nВведите цену {titleLine}:\n");
                int result;
                string? input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    weapon.Price = input;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод! Введите целое число!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            return weapon;
        }
    }
}
