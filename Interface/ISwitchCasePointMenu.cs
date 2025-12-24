using System;
using System.Collections.Generic;
using System.Text;

namespace NewGunShop.Interface
{
    internal interface ISwitchCasePointMenu
    {
        void SwitchCase(IDataWeaponList dataWeaponList, IInputDataProcessor inputDataProcessor);
    }
}
