using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public void ChanceToDodgeAttack(Player enemy)
        {

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
