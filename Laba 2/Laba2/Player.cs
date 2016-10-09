namespace Laba2
{
    abstract class Player: TargetObject
    {
        public override int Life { get; set; }
        public int Strange { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Effects { get; protected set; }
        public int Level { get; protected set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }

        public Player()
        {
            Life = 100;
            Strange = 10;
            Dexterity = 10;
            Intelligence = 10;
            Effects = 0;
            Level = 1;
            Armor = new Armor(20, "подштаники", new Requirements(1,1,1));
            Weapon = new Weapon(10, "камень", new Requirements(1,1,1));
        }

        public Player(int Life, int Strange, int Dexterity, int Intelligence, int Effects, int Level, Armor Armor, Weapon Weapon)
        {
            this.Life = Life;
            this.Strange = Strange;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
            this.Effects = Effects;
            this.Level = Level;
            this.Armor = Armor;
            this.Weapon = Weapon;
        }

        public abstract void Attack(TargetObject targetObject, Effect effect, Weapon weapon);
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void EquipOutfit(Armor armor);
        public abstract void AddEffect(Effect effect);

    }
}
