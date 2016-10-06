using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    class Cure : CastingBase
    {
        public Cure()
        {
            this.Die = GameConstants.Instance.D10;
            this.Cost = 4;
            this.Type = "Healing";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Cure on " +
                target.Name + "!");
            base.Heal(attacker, attacker);
        }
    }
}
