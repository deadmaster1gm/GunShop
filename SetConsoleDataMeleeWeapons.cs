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
            Console.WriteLine($"Введите модель {titleLine}:\n");
            weapon.Model = Console.ReadLine();
            Console.WriteLine($"\nВведите цену {titleLine}:\n");
            weapon.Price = Console.ReadLine();
            return weapon;
        }
    }
}
