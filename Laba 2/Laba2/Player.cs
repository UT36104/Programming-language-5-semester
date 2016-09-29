using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private Effect[] effect = new Effect[] {
            new Effect("оглушение", 2.0),
            new Effect("отравление", 5.0),
            new Effect("пчелиный укус", 2.0),
            new Effect("яд змеи", 2.0)
        };

        public Effect this[int index]
        {
            get
            {
                return effect[index];
            }
        }

        public Player()
        {
            Life = 100;
            Strange = 10;
            Dexterity = 10;
            Intelligence = 10;
            Effects = 0;
            Level = 1;
        }

        public Player(int Life, int Strange, int Dexterity, int Intelligence, int Effects, int Level)
        {
            this.Life = Life;
            this.Strange = Strange;
            this.Dexterity = Dexterity;
            this.Intelligence = Intelligence;
            this.Effects = Effects;
            this.Level = Level;
        }

        public abstract void Attack(TargetObject targetObject, Effect effect, Weapon weapon);
        public abstract void EquipWeapon(Weapon weapon);
        public abstract void EquipOutfit(Armor armor);
        public abstract void AddEffect(Effect effect);

    }
}
