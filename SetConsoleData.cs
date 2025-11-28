using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class SetConsoleData : IDataProvider
    {
        public Weapon GetData()
        {
            string titleLineModel = string.Empty;
            string titleLinePistol = "Введите модель пистолета:";
            string titleLineRifle = "Введите модель винтовки:";
            string titleLineMeleeWeapon = "Введите модель холодного оружия:";
            string titleLineHardWeapon = "Введите модель тяжелого оружия:";
            string titleLineAmmo = "Введите боезапас:";
            string titleLinePrice = "Введите цену:";

            Console.Clear();
            Console.WriteLine("Какой вид оружия желаете добавить?\n\n1.Пистолет\n2.Винтовка\n3.Холодное оружие\n4.Тяжелое оружие\n\n5.Назад");
            switch(Console.ReadLine())
            {
                case "1":
                    titleLineModel = titleLinePistol;
                    break;

                case "2":
                    titleLineModel = titleLineRifle;
                    break;

                case "3":
                    titleLineModel = titleLineMeleeWeapon;
                    break;

                case "4":
                    titleLineModel = titleLineHardWeapon;
                    break;

                case "5":
                    Console.Clear();
                    Menu.MainMenu();
                    break;
                default:
                    ConsoleOutput.ConsoleOutputPointError();
                    break;
            }
            Weapon weapon = new Weapon();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"{titleLineModel}\n");
                        string? input = Console.ReadLine();

                        if (input == "")
                        {
                            ConsoleOutput.ConsoleOutputPointError();
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
                        int result;
                        if (titleLineModel == titleLineMeleeWeapon)
                        {
                            break;
                        }
                        Console.WriteLine($"{titleLineAmmo}\n");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out result))
                        {
                            weapon.Ammo = input;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            ConsoleOutput.ConsoleOutputPointError();
                        }
                    }
                    while (true)
                    {
                        int result;
                        Console.WriteLine($"{titleLinePrice}\n");
                        string? input = Console.ReadLine();

                        if (int.TryParse(input, out result))
                        {
                            weapon.Price = input;
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            ConsoleOutput.ConsoleOutputPointError();
                        }
                    }
                    return weapon;
            }
        }
    }
