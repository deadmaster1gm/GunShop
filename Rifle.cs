using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class Rifle : IWeapon
    {
        public string Model { get; set; }
        public string Ammo { get; set; }
        public string Price { get; set; }
        public string Fire()
        {
            return "Вы отстрелялись из винтовки!";
        }
        public string Reload()
        {
            return "Вы перезарядили винтовку!";
        }
    }
}
