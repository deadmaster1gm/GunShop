using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    public class DeleteWeapon
    {
        private const string WEAPON_LIST = @"D:\weaponList.json";
        private const string WEAPON_LIST_USER = @"D:\weaponListUser.json";
        public static void Delete (int selectselectPointBuyOrSale)
        {
            while (true)
            {
                int result;
                Console.WriteLine("Какое именно оружие желаете удалить?\n");
                GetWeaponList.GetWeapon(selectselectPointBuyOrSale);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(selectselectPointBuyOrSale == 0 ? WEAPON_LIST : WEAPON_LIST_USER));
                    try
                    {
                    weaponList.RemoveAt(result - 1);
                    }
                    catch
                    {
                        ConsoleOutput.ConsoleOutputPointError();
                        continue;
                    }
                    string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                    while(selectselectPointBuyOrSale == 0)
                    {
                        File.WriteAllText(WEAPON_LIST, jsonWeaponList);
                        break;
                    }
                    while(selectselectPointBuyOrSale == 1)
                    {
                        File.WriteAllText(WEAPON_LIST_USER, jsonWeaponList);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Предмет успешно удален!\n");
                    break;
                }
                else
                {
                    ConsoleOutput.ConsoleOutputPointError();
                    Menu.MainMenu();
                }
            }
        }
    }
}
