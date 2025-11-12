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
                    PistolAdd(weaponList);
                    break;
                case "2":
                    RiflelAdd(weaponList);
                    break;
                case "3":
                    MeleelAdd(weaponList);
                    break;
                case "4":
                    //Exit();
                    break;
            }

        }
        public static void WeaponAdd(List<Weapon> weaponList, IDataProvider dataProvider, Weapon gun, ref string titleAdd, ref string titleLine)
        {
            dataProvider.GetData(gun, titleLine);
            weaponList.Add(gun);
            Console.Clear();
            Console.WriteLine(titleAdd);
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu(weaponList);
        }
        public static void PistolAdd(List<Weapon> weaponList)
        {
            string titlePistolAdd = "Пистолет добавлен на склад!";
            string titlePistolLine = "пистолета";
            IDataProvider dataProviderPistol = new SetConsoleData();
            Pistol pistol = new Pistol();
            WeaponAdd(weaponList, dataProviderPistol, pistol, ref titlePistolAdd, ref titlePistolLine);
        }


        public static void RiflelAdd(List<Weapon> weaponList)
        {
            string titleRifleAdd = "Винтовка добавлена на склад!";
            string titleRiflelLine = "винтовки";
            IDataProvider dataProviderRifle = new SetConsoleData();
            Rifle rifle = new Rifle();
            WeaponAdd(weaponList, dataProviderRifle, rifle, ref titleRifleAdd, ref titleRiflelLine);
        }


        public static void MeleelAdd(List<Weapon> weaponList)
        {
            string titleMeleeWeaponAdd = "Нож добавлен на склад!";
            string titleMeleeWeaponLine = "ножа";
            IDataProvider dataProviderMelee = new SetConsoleDataMeleeWeapons();
            MeleeWeapons melee = new MeleeWeapons();
            WeaponAdd(weaponList, dataProviderMelee, melee, ref titleMeleeWeaponAdd, ref titleMeleeWeaponLine);
        }








        // Методы GetWeaponList и ReturnGunOneByOne работают в паре,
        // и выводят список всего что есть на складе
        // загружая и выводя на консоль не пачкой обьектов,
        // а по одному с помощью yield.
        public static void GetWeaponList(List<Weapon> weaponList)
        {
            Console.Clear();
            foreach (var item in ReturnGunOneByOne(weaponList))
            {
                if (item.Ammo == null)
                {
                    Console.WriteLine($"{item.Model} (цена {item.Price})");
                }
                else
                {
                    Console.WriteLine($"{item.Model} с боезапасом {item.Ammo} магазинов (цена {item.Price}$)");
                }
            }
            Console.ReadLine();
            Console.Clear();
            Menu.MainMenu(weaponList);
        }
        public static IEnumerable<T> ReturnGunOneByOne<T>(this List<T> weaponList) 
        {
            foreach (var item in weaponList)
            {
                yield return item;
            }
        }
    }
}
