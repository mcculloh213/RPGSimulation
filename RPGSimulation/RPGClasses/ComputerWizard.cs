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
    public class ComputerWizard : CharacterBase
    {
        public ComputerWizard(string name, int health, int magic)
        {
            this.CharacterClass = "Computer Wizard";
            this.AttackBehavior = new BadGradeAttack();
            this.SpellBehavior = new NoCasting();
            this.SpecialBehavior = new HexReduce();
            this.DefenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
            this.Magic = magic;
            this.CharacterDie = 2 * GameConstants.Instance.D8;
            this.Dodge = 2; // 1:1 hit-miss ratio
        }

        public ComputerWizard(string name)
            : this(name, GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }

        public ComputerWizard()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP, GameConstants.Instance.PlayerMP)
        {

        }
    }
}
