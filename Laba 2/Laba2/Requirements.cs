namespace Laba2
{
    public class Requirements
    {
        public int Strange { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public Requirements()
        {
            Strange = 15;
            Dexterity = 15;
            Intelligence = 15;
        }

        public Requirements(int Strange, int Dexterity, int Intelligence)
        {
            this.Strange = Strange;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
        }
    }
}
