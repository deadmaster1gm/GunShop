using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class MeleeWeapons : Weapon
    {
        public string Fire()
        {
            return "Вы сделали несколько ударов по соломенному манекену!";
        }
    }
}
