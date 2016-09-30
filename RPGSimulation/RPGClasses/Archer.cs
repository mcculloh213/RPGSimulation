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
    public class Archer : CharacterBase
    {
        public Archer(string name, int health, int magic)
        {
            this.CharacterClass = "Archer";
            this.attackBehavior = new BowAttack();
            this.spellBehavior = new NoCasting();
            this.specialBehavior = new NoSpecial();
            this.defenseBehavior = new LeatherArmor();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
        }

        public Archer(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public Archer()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
