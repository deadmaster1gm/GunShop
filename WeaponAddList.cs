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
        public static void WeaponAdd()
        {

            if (File.Exists(WEAPON_LIST))
            {
                List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(WEAPON_LIST));
                IDataProvider dataProvider = new SetConsoleData();
                weaponList.Add(dataProvider.GetData());
                string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                File.WriteAllText(WEAPON_LIST, jsonWeaponList);
                ConsoleOutput.ConsoleOutputAddWeapon();
                Menu.MainMenu();
            }
            else
            {
                IDataProvider dataProvider = new SetConsoleData();
                List<Weapon> weaponList = new List<Weapon>();
                weaponList.Add(dataProvider.GetData());
                string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                File.AppendAllText(WEAPON_LIST, jsonWeaponList);
                ConsoleOutput.ConsoleOutputAddWeapon();
                Menu.MainMenu();
            }

        }
    }
}
