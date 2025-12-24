using System;
using System.Collections.Generic;
using System.Text;
using NewGunShop.Interface;
using NewGunShop.List;

namespace NewGunShop
{
    internal class MainMenu : IMainMenu
    {
        public void PointConsoleOutput(DollarBalance dollarBalance)
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
                        $"БАЛАНС ${dollarBalance._userDollarBalance}");
        }
    }
}

