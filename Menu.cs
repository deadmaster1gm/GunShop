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
            Console.WriteLine("Добро пожаловать в оружейный магазин!\nЧто желаете?\n\n1.Купить оружие\n2.Продать оружие\n3.Выйти\n\n4.Принять оружие на склад (администратор)");
            string point = Console.ReadLine();
            switch(point)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":
                    GunAdd();
                    break;
            }
        }
        public static void GunAdd()
        {
            Console.WriteLine("Какой вид оружия желаете добавить?\n\n1.Пистолет\n2.Винтовка\n3.Холодное оружие\n4.Тяжелое оружие");
            string point = Console.ReadLine();
            switch (point)
            {
                case "1":

                    break;

                case "2":
                    Rifle rifle = new Rifle();
                    IDataProvider dataProvider = new SetConsoleData();
                    dataProvider.GetGata(rifle);
                    break;

                case "3":

                    break;

                case "4":

                    break;
            }

        }

    }
}
