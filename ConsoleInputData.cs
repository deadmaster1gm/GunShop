using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using NewGunShop.Interface;

namespace NewGunShop
{
    internal class ConsoleInputData : IInputDataProcessor
    {
        public Weapon SetData(string path)
        {
            Weapon weapon = new Weapon();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите модель оружия:\n");
                string? input = Console.ReadLine();

                if (input == "")
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!");
                }
                else
                {
                    weapon.Model = input;
                    Console.Clear();
                    break;
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите боезапас:\n");
                int result;
                string? input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    weapon.Ammo = input;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите цену:\n");
                int result;
                string? input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    weapon.Price = input;
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Некорректный ввод!");
                }
            }
            return weapon;
        }
    }
}
