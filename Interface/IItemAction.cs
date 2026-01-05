using System;
using System.Collections.Generic;
using System.Text;

namespace NewGunShop.Interface
{
    interface IItemAction
    {
        void BuyOrSale(List <Weapon> weaponList, string pathSeller, string pathBuyer, string pathDollarBalance, bool methodBuyOrSale);
        void Delete(List<Weapon> weaponList, string pathSeller);
    }
}
