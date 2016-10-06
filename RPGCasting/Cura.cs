using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    class Cura : CastingBase
    {
        public Cura()
        {
            this.Die = GameConstants.Instance.D20 + GameConstants.Instance.D10;
            this.Cost = 8;
            this.Type = "Healing";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Cura on " +
                target.Name + "!");
            base.Heal(attacker, attacker);
        }
    }
}
