using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using NewGunShop.Interface;

namespace NewGunShop
{
    internal class MainMenuSwitchCase : ISwitchCasePointMenu
    {
        private readonly string pathWeaponList = @"weaponList.json";
        private readonly string pathWeaponListUser = @"weaponListUser.json";
        private readonly string pathDollarBalance = @"dollarBalance.json";
        public void SwitchCase(IDataWeaponList dataWeaponList, IInputDataProcessor inputDataProcessor, IItemAction itemAction)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Какое оружие желаете приобрести?\n");
                    itemAction.BuyOrSale(dataWeaponList.GetWeaponList(pathWeaponList), pathWeaponList, pathWeaponListUser, pathDollarBalance, true);
                    Console.ReadLine();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Какое оружие желаете продать?\n");
                    itemAction.BuyOrSale(dataWeaponList.GetWeaponList(pathWeaponListUser), pathWeaponListUser, pathWeaponList, pathDollarBalance, false);
                    Console.ReadLine();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Инвентарь:\n");
                    dataWeaponList.GetWeaponList(pathWeaponListUser);
                    Console.ReadLine();
                    break;
                case "4":
                    return;
                case "5":
                    dataWeaponList.AppendToWeaponList(pathWeaponList, inputDataProcessor.SetData(pathWeaponList));
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Какое оружие удалить со склада?\n");
                    itemAction.Delete(dataWeaponList.GetWeaponList(pathWeaponList), pathWeaponList);
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Склад магазина:\n");
                    dataWeaponList.GetWeaponList(pathWeaponList);
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}
