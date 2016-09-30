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
        public ComputerWizard(string name, int health)
        {
            this.CharacterClass = "Computer Wizard";
            this.attackBehavior = new BadGradeAttack();
            this.spellBehavior = new NoCasting();
            this.specialBehavior = new NoSpecial();
            this.defenseBehavior = new Cloak();
            this.Name = name;
            this.Health = health;
        }

        public ComputerWizard(string name)
            : this(name, GameConstants.Instance.PlayerHP)
        {

        }

        public ComputerWizard()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHP)
        {

        }
    }
}
