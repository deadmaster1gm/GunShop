using Newtonsoft.Json;
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
        public static void MainMenu()
        {
            while(true)
            {
                Console.WriteLine("Добро пожаловать в оружейный магазин!\nЧто желаете?\n\n1.Купить оружие\n2.Продать оружие\n3.Выйти\n\n4.Принять оружие на склад (администратор)\n5.Удалить оружие со склада (администратор)\n6.Посмотреть что на складе (администратор)");
                    
                switch (Console.ReadLine())
                    {
                        case "1":

                            break;

                        case "2":

                            break;

                        case "3":
                            return;

                        case "4":
                            WeaponAddList.WeaponAdd();
                            break;

                        case "5":
                            
                            break;

                        case "6":
                            GetWeaponList.GetWeapon();
                            break;
                        default:
                            ConsoleOutput.ConsoleOutputPointError();
                            break;
                    }
                }
            }
    }
}
