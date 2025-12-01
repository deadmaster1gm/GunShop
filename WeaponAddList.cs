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
        public static void WeaponAdd()
        {
            string filepath = @"D:\weaponList.json";

            if (File.Exists(filepath))
            {
                List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(filepath));
                IDataProvider dataProvider = new SetConsoleData();
                weaponList.Add(dataProvider.GetData());
                string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                File.WriteAllText(filepath, jsonWeaponList);
                ConsoleOutput.ConsoleOutputAddWeapon();
                Menu.MainMenu();
            }
            else
            {
                IDataProvider dataProvider = new SetConsoleData();
                List<Weapon> weaponList = new List<Weapon>();
                weaponList.Add(dataProvider.GetData());
                string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                File.AppendAllText(filepath, jsonWeaponList);
                ConsoleOutput.ConsoleOutputAddWeapon();
                Menu.MainMenu();
            }

        }
    }
}
