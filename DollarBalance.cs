using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GunShop
{
    public class DollarBalance
    {
        private const string DOLLAR_BALANCE = @"D:\dollarBalance.json";
        public int DollarBalanceSeller { get; set; }
        public int DollarBalanceUser { get; set; }

        public DollarBalance()
        {
            
        }

        public static DollarBalance JsonBalanceFileCreate()
        {
            DollarBalance dollarBalance = new DollarBalance();
            if (File.Exists(DOLLAR_BALANCE))
            {
                DollarBalance dollarBalanceJson = JsonSerializer.Deserialize<DollarBalance>(File.ReadAllText(DOLLAR_BALANCE));
                dollarBalance = dollarBalanceJson;
                return dollarBalance;
            }
            else
            {
                DollarBalance dollarBalanse = new DollarBalance();
                dollarBalanse.DollarBalanceUser = 50000;
                dollarBalanse.DollarBalanceSeller = 100000;
                string jsonBalanceList = JsonSerializer.Serialize(dollarBalanse);
                File.AppendAllText(DOLLAR_BALANCE, jsonBalanceList);
                return dollarBalanse;
            }
        }
    }
}
