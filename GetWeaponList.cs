using Newtonsoft.Json;
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
            Menu.MainMenu();
        }
        public static IEnumerable<Weapon> ReturnGunOneByOne()
        {
            string filepath = @"D:\weaponList.json";
            List<Weapon> jsonWeaponList = JsonConvert.DeserializeObject<List<Weapon>>(File.ReadAllText(filepath));
            foreach (var item in jsonWeaponList)
            {
                yield return item;
            }
        }
    }
}
