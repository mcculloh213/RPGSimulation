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
    public class RedMage : CharacterBase
    {
        /// <summary>
        /// All around mage. Higher attack, lower spellcasting ability.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="magic"></param>
        public RedMage(string name, int health, int magic)
        {
            this.CharacterClass = "Red Mage";
            this.AttackBehavior = new Staff();
            this.SpellBehavior = new Firaga();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D12;
            this.Dodge = 4; // 3:1 hit-miss ratio
        }

        public RedMage(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public RedMage()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
