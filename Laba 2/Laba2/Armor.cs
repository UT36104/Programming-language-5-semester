using System;

namespace Laba2
{
    public class Armor
    {
        public int Defense { get; set; }
        public string ArmorType { get; set; }
        public Requirements Requirements { get; set; }

        public enum ArmorDictionary { латы, кожанка, плащ, спортивки, подштаники, трусы, кеприк }

        public Armor(int Defense, string ArmorType, Requirements Requirements)
        {
            this.Defense = Defense;
            foreach (string name in Enum.GetValues(typeof(ArmorDictionary)))
            {
                if (ArmorType == (string)name)
                {
                    this.ArmorType = ArmorType;
                }
                else
                {
                    this.ArmorType = "трусы";
                }
            }
            this.Requirements = Requirements;
        }
    }
}