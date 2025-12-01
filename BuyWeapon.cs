using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GunShop
{
    public class BuyWeapon
    {
        public static void UserBuyWeapon ()
        {
        string filepath = @"D:\dollarBalance.json";

            if (File.Exists(filepath))
            {
                int result;
                Console.Clear();
                Console.WriteLine("Какой предмет желаете приобрести?\n");
                GetWeaponList.GetWeapon();
                string? input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    string filepathList = @"D:\weaponList.json";
                    DollarBalance dollarBalance = JsonSerializer.Deserialize<DollarBalance>(File.ReadAllText(filepath));
                    List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(filepathList));
                    try
                    {
                        string filepathUserWeapon = @"D:\weaponListUser.json";
                        Weapon weapon = weaponList[result - 1];
                        Console.Clear();
                        Console.WriteLine($"Цена покупки {weapon.Price}$\n Уверены?\n\n1.Да\n2.Нет");
                        switch(Console.ReadLine())
                        {
                            case "1":
                                if(File.Exists(filepathUserWeapon))
                                {
                                    List<Weapon> weaponListUserExisting = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(filepathUserWeapon));
                                    weaponListUserExisting.Add(weaponList[result - 1]);
                                    weaponList.RemoveAt(result - 1);
                                    string jsonWeaponListUserExisting = JsonSerializer.Serialize(weaponListUserExisting);
                                    File.WriteAllText(filepathUserWeapon, jsonWeaponListUserExisting);
                                    Console.Clear();
                                    Console.WriteLine("Покупка совершена!");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    List<Weapon> weaponListUser = new List<Weapon>();
                                    weaponListUser.Add(weaponList[result - 1]);
                                    weaponList.RemoveAt(result - 1);
                                    string jsonWeaponListUser = JsonSerializer.Serialize(weaponListUser);
                                    string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                                    File.WriteAllText(filepathUserWeapon, jsonWeaponListUser);
                                    File.WriteAllText(filepathList, jsonWeaponList);
                                    Console.Clear();
                                    Console.WriteLine("Покупка совершена!");
                                    Console.ReadLine();
                                }
                                break;
                            case "2":
                                Console.Clear();
                                UserBuyWeapon();
                                break;
                            default:
                                ConsoleOutput.ConsoleOutputPointError();
                                break;
                        }

                    }
                    
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

            }
            else
            {
                DollarBalance dollarBalanse = new DollarBalance();
                dollarBalanse.DollarBalanceUser = 50000;
                dollarBalanse.DollarBalanceSeller = 100000;
                string jsonBalanceList = JsonSerializer.Serialize(dollarBalanse);
                File.AppendAllText(filepath, jsonBalanceList);
            }
        }
    }
}
