using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    static class Menu
    {
        private const string DOLLAR_BALANCE = @"D:\dollarBalance.json";
        public static void MainMenu()
        {
            int balanceUser = DollarBalance.JsonBalanceFileCreate().DollarBalanceUser;
            DollarBalance dollarBalance = DollarBalance.JsonBalanceFileCreate();
                while (true)
                {
                    Console.WriteLine("Добро пожаловать в оружейный магазин!\n" +
                        "Что желаете?\n\n" +
                        "1.Купить оружие\n" +
                        "2.Продать оружие\n" +
                        "3.Открыть инвентарь\n" +
                        "4.Выйти\n\n" +

                        "5.Принять оружие на склад (администратор)\n" +
                        "6.Удалить оружие со склада (администратор)\n" +
                        "7.Посмотреть что на складе (администратор)\n" +
                        "___________________________________________\n" +
                        $"БАЛАНС {balanceUser}$");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Buy.BuyWeaponFileAndMenuLogic(0,dollarBalance);
                            Console.Clear();
                            break;

                        case "2":
                            Buy.BuyWeaponFileAndMenuLogic(1,dollarBalance);
                            break;

                        case "3":
                            Console.Clear();
                            GetWeaponList.GetWeapon(1);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "4":
                            return;

                        case "5":
                            WeaponAddList.ListExists();
                            break;

                        case "6":
                            Console.Clear();
                            DeleteWeapon.Delete(0);
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case "7":
                            Console.Clear();
                            GetWeaponList.GetWeapon(0);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            ConsoleOutput.ConsoleOutputPointError();
                            break;
                    }
                }
            }
    }
}
