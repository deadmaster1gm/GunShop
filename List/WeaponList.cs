using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using NewGunShop.Interface;

namespace NewGunShop.Interface
{
    internal class WeaponList : IDataWeaponList
    {

        public void GetWeaponList(string path)
        {
            if (File.Exists(path))
            {
                ReturnWeaponsToConsole(path);
            }
            else
            {
                File.WriteAllText(path, "[]");
                ReturnWeaponsToConsole(path);
            }
        }
        public void AppendToWeaponList(string path, Weapon weapon)
        {
            if (File.Exists(path))
            {
                WriteWeaponToList(path, weapon);
            }
            else
            {
                File.WriteAllText(path, "[]");
                WriteWeaponToList(path, weapon);
            }
        }
        private void WriteWeaponToList(string path, Weapon weapon)
        {
            List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(path));
            weaponList.Add(weapon);
            string jsonWeaponList = JsonSerializer.Serialize(weaponList);
            File.WriteAllText(path, jsonWeaponList);
            Console.WriteLine("Оружие добавлено на склад!");
            Console.ReadLine();
        }
        private void ReturnWeaponsToConsole(string path)
        {
            List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(path));

            int i = 0;

            foreach (var item in ReturnGunOneByOne(weaponList))
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
        IEnumerable<Weapon> ReturnGunOneByOne(List<Weapon> weaponList)
        {
            if (weaponList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Пусто!");
            }
            else
            {
                foreach (var item in weaponList)
                {
                    yield return item;
                }
            }
        }
    }
}
