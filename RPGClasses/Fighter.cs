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
    public class Fighter : CharacterBase
    {
        public Fighter(string name, int health, int magic)
        {
            this.CharacterClass = "Fighter";
            this.AttackBehavior = null;
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new NoDefense();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D10;
            this.Dodge = 5; // 4:1 hit-miss ratio
        }

        public Fighter(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Fighter()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
