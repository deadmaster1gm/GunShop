namespace NewGunShop.Interface
{
    internal interface IDataWeaponList
    {
        void GetWeaponList(string path);
        void AppendToWeaponList(string path, Weapon weapon);

    }
}
