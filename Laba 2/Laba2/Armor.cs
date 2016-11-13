using System;

namespace Laba2
{
    public class Armor
    {
        public int Defense { get; set; }
        public enum ArmorType { leather, jacket, coat, sportivki, underpants, briefs }
        public Requirements Requirements { get; set; }

        public Armor(int Defense, enum ArmorType, Requirements Requirements)
        {
            this.Defense = Defense;
            foreach (string name in Enum.GetValues(typeof(ArmorType)))
            {
                if (ArmorType == (string)name)
                {
                    this.ArmorType = name;
                }
                else
                {
                    this.ArmorType = ArmorType.underpants;
                }
            }
            this.Requirements = Requirements;
        }
    }
}