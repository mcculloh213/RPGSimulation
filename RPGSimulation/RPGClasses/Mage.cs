using McCullough.RPGAttacks;
using McCullough.RPGDefenses;
using McCullough.RPGGameConstants;
using McCullough.RPGCasting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGSpecial;

namespace McCullough.RPGClasses
{
    public class Mage : CharacterBase
    {
        public Mage(string name, int health)
        {
            this.CharacterClass = "Mage";
            this.attackBehavior = new Staff();
            this.spellBehavior = new Firaga();
            this.specialBehavior = new NoSpecial();
            this.defenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
        }

        public Mage(string name)
            : this(name, GameConstants.Instance.PlayerHP)
        {

        }

        public Mage()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP)
        {

        }
    }
}
