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
    public class Warlock : CharacterBase
    {
        public Warlock(string name, int health, int magic)
        {
            this.CharacterClass = "Warlock";
            this.AttackBehavior = null;
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new NoDefense();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D8;
            this.Dodge = 5; // 4:1 hit-miss ratio
        }

        public Warlock(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Warlock()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
