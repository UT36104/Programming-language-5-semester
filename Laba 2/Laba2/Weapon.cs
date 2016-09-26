namespace Laba2
{
    public class Weapon : Requirements
    {
        public int Damage { get; set; }
        public string WeaponType { get; set; }
        public Requirements Requirements { get; set; }
    }
}