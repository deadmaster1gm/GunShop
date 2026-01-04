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
        public void SwitchCase(IDataWeaponList dataWeaponList, IInputDataProcessor inputDataProcessor)
        {
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Какое оружие желаете приобрести?\n");
                    dataWeaponList.GetWeaponList(pathWeaponList);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Какое оружие желаете продать?\n");
                    dataWeaponList.GetWeaponList(pathWeaponListUser);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Инвентарь:\n");
                    dataWeaponList.GetWeaponList(pathWeaponListUser);
                    break;
                case "4":
                    return;
                case "5":
                    dataWeaponList.AppendToWeaponList(pathWeaponList, inputDataProcessor.SetData(pathWeaponList));
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Какое оружие удалить со склада?\n");
                    dataWeaponList.GetWeaponList(pathWeaponList);
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Склад магазина:\n");
                    dataWeaponList.GetWeaponList(pathWeaponList);
                    break;
            }
        }
    }
}
