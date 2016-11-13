using System;

namespace Laba2
{
    public class Weapon
    {
        public int Damage { get; set; }
        public Requirements Requirements { get; set; }
        public enum WeaponType { bones, arms, stick, rock, staff }

        public Weapon(int Damage, enum WeaponType, Requirements Requirements)
        {
            this.Damage = Damage;
            foreach (string name in Enum.GetValues(typeof(WeaponType)))
            {
                if (WeaponType == (string)name)
                {
                    this.WeaponType = name;
                }
                else
                {
                    this.WeaponType = WeaponType.bones;
                }
            }
            this.Requirements = Requirements;
        }
    }
}