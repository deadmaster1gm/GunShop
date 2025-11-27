using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class Weapon : IWeapon
    {
        public string Model { get; set; }
        public string Ammo { get; set; }
        public string Price { get; set; }
        public Weapon(string model, string ammo, string price)
        {
            Model = model;
            Ammo = ammo;
            Price = price;
        }
    }
}
