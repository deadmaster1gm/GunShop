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
                    Console.WriteLine("Какое оружие желаете приобрести?");
                    dataWeaponList.GetWeaponList(pathWeaponList);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Какое оружие желаете продать?");
                    dataWeaponList.GetWeaponList(pathWeaponListUser);
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Инвентарь:");
                    dataWeaponList.GetWeaponList(pathWeaponListUser);
                    break;
                case "4":
                    return;
                case "5":
                    dataWeaponList.AppendToWeaponList(pathWeaponList, inputDataProcessor.SetData(pathWeaponList));
                    break;
                case "6":
                    break;
                case "7":
                    break;
            }
        }
    }
}
