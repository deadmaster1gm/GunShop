using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using NewGunShop.Interface;

namespace NewGunShop.List
{
    internal class DollarBalance : IDataDollarBalance
    {
        private readonly string path = @"dollarBalance.json";
        public int _userDollarBalance { get; set; }
        public int _sellerDollarBalance { get; set; }
        public DollarBalance GetBalance()
        {
            if (File.Exists(path))
            {
                return ConsoleOutputBalance();
            }
            else
            {
                DollarBalance dollarBalance = new DollarBalance();
                dollarBalance._userDollarBalance = 50000;
                dollarBalance._sellerDollarBalance = 100000;
                string jsonDollarBalance = JsonSerializer.Serialize(dollarBalance);
                File.WriteAllText(path, jsonDollarBalance);
                return dollarBalance;
            }
        }
        private DollarBalance ConsoleOutputBalance()
        {
            DollarBalance dollarBalance = JsonSerializer.Deserialize<DollarBalance>(File.ReadAllText(path));
            return dollarBalance;
        }
    }
}