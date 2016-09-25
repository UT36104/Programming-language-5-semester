namespace Laba2
{
    class Wizard: Player
    {
        public int Mana { get; set; }
        
        public Wizard()
        {
            Life = 100;
            Strange = 10;
            Dexterity = 10;
            Intelligence = 10;
        }

        public Wizard(int Life, int Strange, int Dexterity, int Intelligence, int Mana)
        {
            this.Life = Life;
            this.Strange = Strange;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
            this.Mana = Mana;
        }

        public void LevelUp()
        {
            Level += 1;
            Strange += 3;
            Dexterity += 3;
            Intelligence += 3;
        }

        public int ChanceToDodgeAttack(int attack)
        {
            return Dexterity / attack / 100;
        }

        public bool CanAttack(Effect effect)
        {
            if (effect.Duration == -1)
                return true;
            return false;
        }

        public override void Attack(TargetObject targetObject)
        {
            
        }

        public override void EquipWeapon(Weapon weapon)
        {
            
        }

        public override void EquipOutfit(Armor armor)
        {
            
        }

        public override void AddEffect(Effect effect)
        {
           
        }
    }
}
