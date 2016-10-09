using System;

namespace Laba2
{
    public class Weapon
    {
        public int Damage { get; set; }
        public string WeaponType { get; set; }
        public Requirements Requirements { get; set; }

        public enum WeaponDictionary { дубина, кулаки, палка, камень, посох }

        public Weapon(int Damage, string WeaponType, Requirements Requirements)
        {
            this.Damage = Damage;
            foreach (string name in Enum.GetValues(typeof(WeaponDictionary)))
            {
                if (WeaponType == (string)name)
                {
                    this.WeaponType = WeaponType;
                }
                else
                {
                    this.WeaponType = "палка";
                }
            }
            this.Requirements = Requirements;
        }
    }
}