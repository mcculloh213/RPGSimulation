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
    public class Cactuar : CharacterBase
    {
        public Cactuar(string name, int health, int magic)
        {
            this.CharacterClass = "Cactuar";
            this.AttackBehavior = new OneThousandNeedles();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new NoSpecial();
            this.DefenseBehavior = new NoDefense();
            this.Name = name;
            this.Health = health;
            this.Magic = -1; // Cactuar cannot comprehend magic
            this.CharacterDie = GameConstants.Instance.D6;
            this.Dodge = 2; // 1:1 hit-miss ratio
        }

        public Cactuar(string name)
            : this(name, GameConstants.Instance.PlayerHP, -1)
        {

        }

        public Cactuar()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, -1)
        {

        }
    }
}
