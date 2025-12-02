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
        private const string WEAPON_LIST = @"D:\weaponList.json";
        private const string WEAPON_LIST_USER = @"D:\weaponListUser.json";

        public static void GetWeapon(int selectPointBuyOrSale)
        {
            if (File.Exists(selectPointBuyOrSale == 0 ? WEAPON_LIST : WEAPON_LIST_USER) != true)
            {
                while(selectPointBuyOrSale == 0)
                {
                Console.WriteLine("Склад магазина пуст!");
                    break;
                }
                while(selectPointBuyOrSale == 1)
                {
                    ConsoleOutput.ConsoleOutputInventoryEmpty();
                    break;
                }
            }
            else
            {
                int i = 0;

                foreach (var item in ReturnGunOneByOne(selectPointBuyOrSale))
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
        public static IEnumerable<Weapon> ReturnGunOneByOne(int selectpointBuyOrSale)
        {
            List<Weapon> jsonWeaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(selectpointBuyOrSale == 0 ? WEAPON_LIST : WEAPON_LIST_USER));
            if (jsonWeaponList.Count == 0)
            {
                while(selectpointBuyOrSale == 0)
                {
                    ConsoleOutput.ConsoleOutStorageEmpty();
                }
                while(selectpointBuyOrSale == 1)
                {
                    ConsoleOutput.ConsoleOutputInventoryEmpty();
                    break;
                }
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
