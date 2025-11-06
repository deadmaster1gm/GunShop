using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class SetConsoleData : IDataProvider
    {
        public IWeapon GetGata(IWeapon weapon)
        {
            Console.WriteLine("Введите модель винтовки:\n");
            weapon.Model = Console.ReadLine();
            Console.WriteLine("Введите боезапас винтовки:\n");
            weapon.Ammo = Console.ReadLine();
            Console.WriteLine("Введите цену винтовки:\n");
            weapon.Price = Console.ReadLine();
            return weapon;
        }
    }
}
