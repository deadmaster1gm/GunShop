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
        public static void ConsoleOutStorageEmpty ()
        {
            Console.Clear();
            Console.WriteLine("Склад магазина пуст!");
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }
        public static void ConsoleOutputBuySuccessfuly()
        {
            Console.Clear();
            Console.WriteLine("Покупка совершена!");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ConsoleOutputSaleSuccessfuly()
        {
            Console.Clear();
            Console.WriteLine("Вы успешно продали предмет!");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ConsoleOutputInventoryEmpty()
        {
            Console.Clear();
            Console.WriteLine("У вас нет оружия!");
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu();
        }
    }
}
