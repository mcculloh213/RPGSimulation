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
    public class Tonberry : CharacterBase
    {
        public Tonberry(string name, int health, int magic)
        {
            this.CharacterClass = "Tonberry";
            this.AttackBehavior = new ChefKnife();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new High();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D20;
            this.Dodge = 6; // 5:1 hit-miss ratio
        }

        public Tonberry(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Tonberry()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
