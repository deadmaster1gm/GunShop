using NewGunShop.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace NewGunShop
{
    class ItemAction : IItemAction
    {
        public void Buy(List <Weapon> weaponList)
        {
            while (true)
            {
                int result;
                string? input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    Console.WriteLine("Успешно!");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!");
                }
            }
        }

        public void Sale()
        {
            throw new NotImplementedException();
        }
    }
}
