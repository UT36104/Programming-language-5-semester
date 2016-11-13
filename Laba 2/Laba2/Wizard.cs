﻿using System;

namespace Laba2
{
    class Wizard : Player
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

        protected int AttackUp
        {
            get { return Intelligence * 5; }
        }

        public int ChanceToDodgeAttack(int attack)
        {
            return Dexterity / attack / 100;
        }

        public bool CanAttack(Effect effect)
        {
            bool status = true;
            foreach (string name in Enum.GetValues(typeof(Effect.EffectType)))
            {
                if (effect.EffectType == EffectType.stun)
                {
                    status = false;
                }
            }
            return status;
        }

        public override void Attack(TargetObject targetObject)
        {
            if (CanAttack())
            {
                targetObject.Life = targetObject.Life - weapon.Damage;
            }
        }

        public override void EquipWeapon(Weapon weapon)
        {
            if (weapon.Requirements != new Requirements(Strange, Dexterity, Intelligence))
            {
                new PlayerOutfitException("НЕДОСТАТОЧНО СТАТОВ");
            }
            if (weapon.WeaponType != weapon.WeaponType.staff)
            {
                new PlayerOutfitException("ТИП ОРУЖИЯ НЕ ПОДХОДИТ");
            }
        }

        public override void EquipOutfit(Armor armor)
        {
            if (armor.Requirements != new Requirements(Strange, Dexterity, Intelligence))
            {
                new PlayerOutfitException("НЕДОСТАТОЧНО СТАТОВ");
            }
            if (armor.ArmorType != armor.ArmorType.coat)
            {
                new PlayerOutfitException("ТИП БРОНИ НЕ ПОДХОДИТ");
            }
        }

        public override void AddEffect(Effect effect)
        {
            if (effect.Duration == -1)
            {
                effect = new Effect(effect.EffectType, effect.Duration);
            }
        }
    }
}
