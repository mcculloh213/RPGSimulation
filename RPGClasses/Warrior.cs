using McCullough.RPGAttacks;
using McCullough.RPGCasting;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;
using McCullough.RPGSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    public class Warrior : CharacterBase
    {
        public Warrior(string name, int health, int magic)
        {
            this.CharacterClass = "Warrior";
            this.AttackBehavior = new SwordAttack();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new MultiAttack();
            this.DefenseBehavior = new HeavyShield();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D12;
            this.Dodge = 3; // 2:1 hit-miss ratio
        }

        public Warrior(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Warrior()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
