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
            this.Name = name;
            this.Health = health;
        }

        public ComputerWizard(string name)
            : this(name, GameConstants.Instance.PlayerHitpoints)
        {

        }

        public ComputerWizard()
            : this(CharacterBase.AnonymousName + (++CharacterBase.anonymousCounter).ToString(),
                  GameConstants.Instance.PlayerHitpoints)
        {

        }
    }
}
