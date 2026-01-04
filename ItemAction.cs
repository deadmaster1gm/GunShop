using NewGunShop.Interface;
using NewGunShop.List;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace NewGunShop
{
    class ItemAction : IItemAction
    {
        public void Buy(List<Weapon> weaponList, string pathSeller, string pathBuyer, string pathDollarBalance)
        {
            while (true)
            {
                if (weaponList.Count == 0)
                {
                    break;
                }
                else
                {
                    int result;
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out result))
                    {
                        Weapon weapon = weaponList[result - 1];
                        List<Weapon> weaponListUser = JsonSerializer.Deserialize<List<Weapon>>(File.ReadAllText(pathBuyer));
                        weaponListUser.Add(weapon);
                        string jsonWeaponListUser = JsonSerializer.Serialize(weaponListUser);
                        File.WriteAllText(pathBuyer, jsonWeaponListUser);

                        weaponList.RemoveAt(result - 1);
                        string jsonWeaponList = JsonSerializer.Serialize(weaponList);
                        File.WriteAllText(pathSeller, jsonWeaponList);

                        DollarBalance dollarBalance = JsonSerializer.Deserialize<DollarBalance>(File.ReadAllText(pathDollarBalance));
                        int balanceSeller = dollarBalance._sellerDollarBalance;
                        int balanceBuyer = dollarBalance._userDollarBalance;
                        int priceWeapon = int.Parse(weapon.Price);
                        int resultBalanceSeller = balanceSeller + priceWeapon;
                        int resultBalanceBuyer = balanceBuyer - priceWeapon;
                        dollarBalance._sellerDollarBalance = resultBalanceSeller;
                        dollarBalance._userDollarBalance = resultBalanceBuyer;
                        string jsonDollarBalance = JsonSerializer.Serialize(dollarBalance);
                        File.WriteAllText(pathDollarBalance, jsonDollarBalance);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод!");
                    }
                }
                Console.Clear();
                Console.WriteLine("Успешно!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void Sale()
        {
            throw new NotImplementedException();
        }
    }
}
