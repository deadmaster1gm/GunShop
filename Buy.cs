using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GunShop
{
    public static class Buy
    {
        private const string WEAPON_LIST = @"D:\weaponList.json";
        private const string WEAPON_LIST_USER = @"D:\weaponListUser.json";
        private const string DOLLAR_BALANCE = @"D:\dollarBalance.json";

        private static void BuyWeapon(List<Weapon> weaponList,List<Weapon> weaponListUser, DollarBalance dollarBalance, Weapon weapon, int result, int selectPointBuyOrSale)
        {
            while(selectPointBuyOrSale == 0)
            {
                weaponListUser.Add(weaponList[result - 1]);
                weaponList.RemoveAt(result - 1);
                break;
            }
            while(selectPointBuyOrSale == 1)
            {
                weaponList.Add(weaponListUser[result - 1]);
                weaponListUser.RemoveAt(result - 1);
                break;
            }
            int dollarBalanceUser = dollarBalance.DollarBalanceUser;
            int dollarBalanceSeller = dollarBalance.DollarBalanceSeller;
            int weaponPrice = int.Parse(weapon.Price);
            while(selectPointBuyOrSale == 0)
            {
                dollarBalance.DollarBalanceUser = dollarBalanceUser - weaponPrice;
                dollarBalance.DollarBalanceSeller = dollarBalanceSeller + weaponPrice;
                break;
            }
            while(selectPointBuyOrSale == 1)
            {
                dollarBalance.DollarBalanceUser = dollarBalanceUser + weaponPrice;
                dollarBalance.DollarBalanceSeller = dollarBalanceSeller - weaponPrice;
                break;
            }
            string jsonWeaponListUser = JsonSerializer.Serialize(weaponListUser);
            string jsonWeaponList = JsonSerializer.Serialize(weaponList);
            string jsonDollarBalance = JsonSerializer.Serialize(dollarBalance);

            File.WriteAllText(WEAPON_LIST_USER, jsonWeaponListUser);
            File.WriteAllText(WEAPON_LIST, jsonWeaponList);
            File.WriteAllText(DOLLAR_BALANCE, jsonDollarBalance);
            while(selectPointBuyOrSale == 0)
            {
                ConsoleOutput.ConsoleOutputBuySuccessfuly();
                break;
            }
            while(selectPointBuyOrSale == 1)
            {
                ConsoleOutput.ConsoleOutputSaleSuccessfuly();
                break;
            }
            Menu.MainMenu();
        }
        public static void BuyWeaponFileAndMenuLogic (int selectPointBuyOrSale)
        {

            if (File.Exists(DOLLAR_BALANCE))
            {
                int result;
                Console.Clear();
                while(selectPointBuyOrSale == 0)
                {
                    Console.WriteLine("Какой предмет желаете приобрести?\n");
                    break;
                }
                while (selectPointBuyOrSale == 1)
                {
                    Console.WriteLine("Какой предмет желаете продать?\n");
                    break;
                }
                GetWeaponList.GetWeapon(selectPointBuyOrSale);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    DollarBalance dollarBalance = JsonSerializer.Deserialize<DollarBalance>(File.ReadAllText(DOLLAR_BALANCE));
                    List<Weapon> weaponList = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(selectPointBuyOrSale == 0 ? WEAPON_LIST : WEAPON_LIST_USER));
                    try
                    {
                        Weapon weapon = weaponList[result - 1];
                        Console.Clear();
                        while(selectPointBuyOrSale == 0)
                        {
                            Console.WriteLine($"Цена покупки {weapon.Price}$\n Уверены?\n\n1.Да\n2.Нет");
                            break;
                        }
                        while(selectPointBuyOrSale == 1)
                        {
                            Console.WriteLine($"Цена продажи {weapon.Price}$\n Уверены?\n\n1.Да\n2.Нет");
                            break;
                        }
                        switch (Console.ReadLine())
                        {
                            case "1":
                                if(File.Exists(WEAPON_LIST_USER))
                                {
                                    while(selectPointBuyOrSale == 1)
                                    {
                                        List<Weapon> weaponListUser = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(WEAPON_LIST_USER));
                                        List<Weapon> weaponListBase = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(WEAPON_LIST));
                                        BuyWeapon(weaponListBase, weaponListUser, dollarBalance, weapon, result, selectPointBuyOrSale);
                                        break;
                                    }
                                    while(selectPointBuyOrSale == 0)
                                    {
                                        List<Weapon> weaponListUser = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(WEAPON_LIST_USER));
                                        BuyWeapon(weaponList, weaponListUser, dollarBalance, weapon, result, selectPointBuyOrSale);
                                        break;
                                    }
                                }
                                else
                                {
                                    List<Weapon> weaponListUser = new List<Weapon>();
                                    BuyWeapon(weaponList, weaponListUser, dollarBalance, weapon, result, selectPointBuyOrSale);
                                }
                                break;
                            case "2":
                                Console.Clear();
                                BuyWeaponFileAndMenuLogic(selectPointBuyOrSale);
                                break;
                            default:
                                ConsoleOutput.ConsoleOutputPointError();
                                break;
                        }

                    }
                    
                    catch
                    {
                        ConsoleOutput.ConsoleOutputPointError();
                    }
                }
                else
                {
                    ConsoleOutput.ConsoleOutputPointError();
                    Menu.MainMenu();
                }

            }
            else
            {
                DollarBalance.SetDollarBalance();
            }
        }
    }
}
