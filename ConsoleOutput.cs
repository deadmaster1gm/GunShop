using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    public static class ConsoleOutput
    {
        public static void ConsoleOutputPointError()
        {
            Console.Clear();
            Console.WriteLine("Некорректный ввод!");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ConsoleOutputAddWeapon()
        {
            Console.Clear();
            Console.WriteLine("Оружие добавлено на склад!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
