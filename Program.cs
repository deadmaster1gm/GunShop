using Microsoft.Extensions.DependencyInjection;
using NewGunShop.Interface;
using NewGunShop.List;
using NewGunShop;

IServiceCollection services = new ServiceCollection();
services.AddTransient<GunShop>();
services.AddTransient<IMainMenu, MainMenu>();
services.AddTransient<ISwitchCasePointMenu, MainMenuSwitchCase>();
services.AddTransient<IInputDataProcessor, ConsoleInputData>();
services.AddTransient<IDataWeaponList, WeaponList>();
services.AddTransient<IDataDollarBalance, DollarBalance>();

var serviceProvider = services.BuildServiceProvider();

var gunShopService = serviceProvider.GetRequiredService<GunShop>();
while (true)
{
    gunShopService.GetMainMenu();
}
class GunShop
{
    private readonly IMainMenu _mainMenu;
    private readonly ISwitchCasePointMenu _switchCasePointMenu;
    private readonly IInputDataProcessor _inputDataProcessor;
    private readonly IDataWeaponList _dataWeaponList;
    private readonly IDataDollarBalance _dataDollarBalance;
    public GunShop(IMainMenu mainMenu, ISwitchCasePointMenu switchCasePointMenu, IInputDataProcessor inputDataProcessor, IDataWeaponList dataWeaponList, IDataDollarBalance dataDollarBalance)
    {
        _mainMenu = mainMenu;
        _switchCasePointMenu = switchCasePointMenu;
        _inputDataProcessor = inputDataProcessor;
        _dataWeaponList = dataWeaponList;
        _dataDollarBalance = dataDollarBalance;
    }
    public void GetMainMenu()
    {
        _mainMenu.PointConsoleOutput(_dataDollarBalance.GetBalance());
        _switchCasePointMenu.SwitchCase(_dataWeaponList, _inputDataProcessor);
    }
}