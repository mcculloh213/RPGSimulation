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
    public class Troll : CharacterBase
    {
        public Troll(string name, int health, int magic)
        {
            this.CharacterClass = "Troll";
            this.AttackBehavior = new Staff();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new NoDefense();
            this.Name = name;
            this.Health = health;
            this.Magic = -1;
            this.CharacterDie = GameConstants.Instance.D20;
            this.Dodge = 1; // So big, that a hit is always guaranteed.
        }

        public Troll(string name)
            : this(name, GameConstants.Instance.PlayerHP, -1)
        {

        }

        public Troll()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, -1)
        {

        }
    }
}
