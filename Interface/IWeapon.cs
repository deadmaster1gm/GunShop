namespace NewGunShop.Interface
{
    internal interface IWeapon
    {
        string Model { get; set; }
        string Ammo { get; set; }
        string Price { get; set; }
    }
}