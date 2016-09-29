namespace Laba2
{
    public class Armor : Requirements
    {
        public int Defense { get; set; }
        public string ArmorType { get; set; }
        public Requirements Requirements { get; set; }

        public Armor(int Defense, string ArmorType, Requirements Requirements)
        {
            this.Defense = Defense;
            this.ArmorType = ArmorType;
            this.Requirements = Requirements;
        }
    }
}