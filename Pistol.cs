using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    class Pistol : Weapon
    {
        public string Fire()
        {
            return "Вы отстрелялись из пистолета!";
        }
        public string Reload()
        {
            return "Вы перезарядили пистолет!";
        }
    }
}
