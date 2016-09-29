namespace Laba2
{
    public class Weapon : Requirements
    {
        public int Damage { get; set; }
        public string WeaponType { get; set; }
        public Requirements Requirements { get; set; }

        public Weapon(int Damage, string WeaponType, Requirements Requirements)
        {
            this.Damage = Damage;
            this.WeaponType = WeaponType;
            this.Requirements = Requirements;
        }
    }
}