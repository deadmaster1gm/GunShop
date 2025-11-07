using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunShop
{
    interface IDataProvider
    {
        Weapon GetData(Weapon weapon, string titleLine);
    }
}
