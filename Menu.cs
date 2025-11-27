using Newtonsoft.Json;
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
                Console.WriteLine("Добро пожаловать в оружейный магазин!\nЧто желаете?\n\n1.Купить оружие\n2.Продать оружие\n3.Выйти\n\n4.Принять оружие на склад (администратор)\n5.Посмотреть что на складе (администратор)");
                int result;
                string? point = Console.ReadLine();
                if (point == "")
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if ((int.TryParse(point, out result)) != true)
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    switch (point)
                    {
                        case "1":

                            break;

                        case "2":

                            break;

                        case "3":
                            return;

                        case "4":
                            WeaponAddMenu();
                            break;

                        case "5":
                            GetWeaponList();
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        public static void WeaponAddMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Какой вид оружия желаете добавить?\n\n1.Пистолет\n2.Винтовка\n3.Холодное оружие\n4.Тяжелое оружие\n\n5.Назад");
                int result;
                string? point = Console.ReadLine();
                if (point == "")
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if ((int.TryParse(point, out result)) != true)
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    switch (point)
                    {
                        case "1":
                            string titleLinePistol = "пистолета";
                            WeaponAdd(titleLinePistol);
                            break;
                        case "2":
                            string titleLineRifle = "винтовки";
                            WeaponAdd(titleLineRifle);
                            break;
                        case "3":
                            string titleLineMelee = "ножа";
                            WeaponAdd(titleLineMelee);
                            break;
                        case "4":
                            
                            break;
                        case "5":
                            Console.Clear();
                            Menu.MainMenu();
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!Выберите пункт!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        public static void WeaponAdd(string titleLine)
        {
            IDataProvider dataProvider = new SetConsoleData();
            string jsonWeaponList = JsonConvert.SerializeObject(dataProvider.GetData(titleLine));
            string filepath = @"D:\weaponList.json";
            File.AppendAllText(filepath, jsonWeaponList);

            Console.Clear();
            Console.WriteLine("Пистолет добавлен на склад!");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }

        // Методы GetWeaponList и ReturnGunOneByOne работают в паре,
        // и выводят список всего что есть на складе
        // загружая и выводя на консоль не пачкой обьектов,
        // а по одному с помощью yield.
        public static void GetWeaponList()
        {
            Console.Clear();
            if (File.Exists(@"D:\weaponList.json") != true)
            {
                Console.WriteLine("Склад магазина пуст!");
            }
            else
            {
                foreach (var item in ReturnGunOneByOne())
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
            }
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
        public static IEnumerable<Weapon> ReturnGunOneByOne() 
        {
            string filepath = @"D:\weaponList.json";
            List<Weapon> jsonWeaponList = JsonConvert.DeserializeObject<List<Weapon>>(filepath);
            foreach (var item in jsonWeaponList)
            {
                yield return item;
            }
        }
    }
}
