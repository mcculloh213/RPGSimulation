using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGAttacks;
using McCullough.RPGCasting;
using McCullough.RPGSpecial;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;

namespace McCullough.RPGClasses
{
    public class Cleric : CharacterBase
    {
        public Cleric(string name, int health, int magic)
        {
            this.CharacterClass = "Cleric";
            this.AttackBehavior = new Club();
            this.SpellBehavior = new Cura();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new SmallShield();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = GameConstants.Instance.D8;
            this.Dodge = 5; // 4:1 hit-miss ratio
        }

        public Cleric(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Cleric()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
