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
        public static void MainMenu(List<Weapon> weaponList)
        {
            Console.WriteLine("Добро пожаловать в оружейный магазин!\nЧто желаете?\n\n1.Купить оружие\n2.Продать оружие\n3.Выйти\n\n4.Принять оружие на склад (администратор)\n5.Посмотреть что на складе (администратор)");
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
                    WeaponAdd(weaponList);
                    break;

                case "5":
                    GetWeaponList(weaponList);
                    break;
            }
        }
        public static void WeaponAdd(List<Weapon> weaponList)
        {
            Console.Clear();
            Console.WriteLine("Какой вид оружия желаете добавить?\n\n1.Пистолет\n2.Винтовка\n3.Холодное оружие\n4.Тяжелое оружие");
            string point = Console.ReadLine();
            switch (point)
            {
                case "1":
                    string titlePistolAdd = "Пистолет добавлен на склад!";
                    string titlePistolLine = "пистолета";
                    Pistol pistol = new Pistol();
                    WeaponAdd(weaponList, pistol, titlePistolAdd, titlePistolLine);
                    break;

                case "2":
                    string titleRifleAdd = "Винтовка добавлена на склад!";
                    string titleRiflelLine = "винтовки";
                    Rifle rifle = new Rifle();
                    WeaponAdd(weaponList, rifle, titleRifleAdd, titleRiflelLine);
                    break;

                case "3":

                    break;

                case "4":

                    break;
            }

        }
        public static void WeaponAdd(List<Weapon> weaponList, Weapon gun, string titleAdd, string titleLine)
        {
            IDataProvider dataProvider = new SetConsoleData();
            dataProvider.GetData(gun, titleLine);
            weaponList.Add(gun);
            Console.Clear();
            Console.WriteLine(titleAdd);
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu(weaponList);
        }

        public static void GetWeaponList(List<Weapon> weaponList)
        {
            Console.Clear();
            foreach (var item in weaponList)
            {
                Console.WriteLine($"{item.Model} с боезапасом {item.Ammo} (цена {item.Price})");
            }
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu(weaponList);
        }
    }
}
