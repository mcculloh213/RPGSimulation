using McCullough.RPGAttacks;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;
using McCullough.RPGCasting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGSpecial;

namespace McCullough.RPGClasses
{
    public class Mage : CharacterBase
    {
        public Mage(string name, int health, int magic)
        {
            this.CharacterClass = "Mage";
            this.AttackBehavior = new Staff();
            this.SpellBehavior = new Firaga();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D8;
            this.Dodge = 4; // 3:1 hit-miss ratio
        }

        public Mage(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Mage()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
