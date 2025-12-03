using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    public static class WeaponAddList
    {
        private const string WEAPON_LIST = @"D:\weaponList.json";
        public static void ListExists()
        {
            bool exists;

            if (File.Exists(WEAPON_LIST))
            {
                exists = true;
                List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(WEAPON_LIST));
                AddWeapon(weaponList, exists);
            }
            else
            {
                exists = false;
                List<Weapon> weaponList = new List<Weapon>();
                AddWeapon(weaponList, exists);
            }

        }
        static void AddWeapon (List <Weapon> weaponList, bool exists)
        {
            IDataProvider dataProvider = new SetConsoleData();
            weaponList.Add(dataProvider.GetData());
            string jsonWeaponList = JsonSerializer.Serialize(weaponList);
            if(exists)
            {
                File.WriteAllText(WEAPON_LIST, jsonWeaponList);
            }
            else
            {
                File.AppendAllText(WEAPON_LIST, jsonWeaponList);
            }
            ConsoleOutput.ConsoleOutputAddWeapon();
            Menu.MainMenu();
        }
    }
}
