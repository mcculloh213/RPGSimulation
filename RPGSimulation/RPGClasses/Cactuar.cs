using McCullough.RPGAttacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    public class Cactuar : CharacterBase
    {
        public Cactuar(string name, int health)
        {
            this.CharacterClass = "Cactuar";
            this.attackBehavior = new OneThousandNeedles();
            this.Name = name;
            this.Health = health;
        }

        public Cactuar(string name)
            : this(name, GameConstants.Instance.PlayerHP)
        {

        }

        public Cactuar()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP)
        {

        }
    }
}
