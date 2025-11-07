using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    interface IWeapon
    {
        string Model { get; set; }
        string Ammo { get; set; }
        string Price { get; set; }
    }
}
