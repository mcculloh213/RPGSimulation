using McCullough.LCRNG;
using McCullough.RPGAttacks;
using McCullough.RPGCasting;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using McCullough.RPGSpecial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    public class BlackMage : CharacterBase
    {
        protected ICasting MagicSelect()
        {
            ICasting spellBehavior;
            int roll = LCRNG32.Instance.Next(2);
            if (roll == 0)
            {
                spellBehavior = new Firaga();
            }
            else if (roll == 1)
            {
                spellBehavior = new Blizzaga();
            }
            else
            {
                spellBehavior = new Thundaga();
            }
            return spellBehavior;
        }

        public BlackMage(string name, int health, int magic)
        {
            this.CharacterClass = "Black Mage";
            this.AttackBehavior = new Staff();
            this.SpellBehavior = MagicSelect();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D8;
            this.Dodge = 4; // 3:1 hit-miss ratio
        }

        public BlackMage(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public BlackMage()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
