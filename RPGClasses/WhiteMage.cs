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
    public class WhiteMage : CharacterBase
    {
        /// <summary>
        /// Standard healing mage.
        /// </summary>
        /// <param name="name">String Character name</param>
        /// <param name="health">Integer Character HP</param>
        /// <param name="magic">Integer Character MP</param>
        public WhiteMage(string name, int health, int magic)
        {
            this.CharacterClass = "White Mage";
            this.AttackBehavior = new Staff();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D8;
            this.Dodge = 4; // 3:1 hit-miss ratio
        }

        public WhiteMage(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public WhiteMage()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
