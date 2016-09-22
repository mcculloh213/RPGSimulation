using McCullough.RPGAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    public class Archer : CharacterBase
    {
        public Archer(string name, int health)
        {
            this.CharacterClass = "Archer";
            this.attackBehavior = new BowAttack();
            this.Name = name;
            this.Health = health;
        }

        public Archer(string name)
            : this(name, GameConstants.Instance.PlayerHP)
        {

        }

        public Archer()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP)
        {

        }
    }
}
