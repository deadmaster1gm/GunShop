using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    // Методы GetWeaponList и ReturnGunOneByOne работают в паре,
    // и выводят список всего что есть на складе
    // загружая и выводя на консоль не пачкой обьектов,
    // а по одному с помощью yield.

    static class GetWeaponList
    {
        public static void GetWeapon()
        {
            string filepath = @"D:\weaponList.json";
            if (File.Exists(filepath) != true)
            {
                Console.WriteLine("Склад магазина пуст!");
            }
            else
            {
                int i = 0;

                foreach (var item in ReturnGunOneByOne())
                {
                    i++;
                    if (item.Ammo == null)
                    {
                        Console.WriteLine($"{i}. {item.Model} (цена {item.Price})");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. {item.Model} с боезапасом {item.Ammo} магазинов (цена {item.Price}$)");
                    }
                }
            }
        }
        public static IEnumerable<Weapon> ReturnGunOneByOne()
        {
            string filepath = @"D:\weaponList.json";
            List<Weapon> jsonWeaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(filepath));
            if (jsonWeaponList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Склад магазина пуст!");
                Console.ReadLine();
                Console.Clear();
                Menu.MainMenu();
            }
            else
            {
                foreach (var item in jsonWeaponList)
                {
                    yield return item;
                }
            }
        }
    }
}
