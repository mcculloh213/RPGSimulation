using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGCasting;
using McCullough.RPGSpecial;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;

namespace McCullough.RPGClasses
{
    public class Sorcerer : CharacterBase
    {
        public Sorcerer(string name, int health, int magic)
        {
            this.CharacterClass = "Sorcerer";
            this.AttackBehavior = null;
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new NoDefense();
            this.Name = name;
            this.Health = Int32.MaxValue;
            this.Magic = Int32.MaxValue;
            this.CharacterDie = GameConstants.Instance.D6;
            this.Dodge = 5; // 4:1 hit-miss ratio
        }

        public Sorcerer(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Sorcerer()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
