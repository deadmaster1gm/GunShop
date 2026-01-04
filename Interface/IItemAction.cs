using System;
using System.Collections.Generic;
using System.Text;

namespace NewGunShop.Interface
{
    interface IItemAction
    {
        void Buy(List <Weapon> weaponList, string pathSeller, string pathBuyer, string pathDollarBalance);
        void Sale();
    }
}
