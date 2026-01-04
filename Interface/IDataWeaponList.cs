namespace NewGunShop.Interface
{
    internal interface IDataWeaponList
    {
        List <Weapon> GetWeaponList(string path);
        void AppendToWeaponList(string path, Weapon weapon);

    }
}
