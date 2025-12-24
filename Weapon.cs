using System;
using System.Collections.Generic;
using System.Text;
using NewGunShop.Interface;

namespace NewGunShop
{
    public class Weapon : IWeapon
    {
        public string Model { get; set; }
        public string Ammo { get; set; }
        public string Price { get; set; }
    }
}
