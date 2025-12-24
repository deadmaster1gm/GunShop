using System;
using System.Collections.Generic;
using System.Text;
using NewGunShop.List;

namespace NewGunShop.Interface
{
    internal interface IDataDollarBalance
    {
        int _userDollarBalance { get; set; }
        int _sellerDollarBalance { get; set; }
        DollarBalance GetBalance();
    }
}
