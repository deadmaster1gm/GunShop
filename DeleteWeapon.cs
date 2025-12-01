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
        public static void Delete ()
        {
            while (true)
            {
                int result;
                Console.WriteLine("Какое именно оружие желаете удалить?\n");
                GetWeaponList.GetWeapon();
                string? input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    string filepath = @"D:\weaponList.json";
                    List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(filepath));
                    try
                    {
                    weaponList.RemoveAt(result - 1);
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }
                    string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                    File.WriteAllText(filepath, jsonWeaponList);
                    Console.Clear();
                    Console.WriteLine("Предмет успешно удален!\n");
                    break;
                }
                else
                {
                    ConsoleOutput.ConsoleOutputPointError();
                }
            }
        }
    }
}
