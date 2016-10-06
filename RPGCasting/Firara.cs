using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Firara : CastingBase
    {
        public Firara()
        {
            this.Die = GameConstants.Instance.D20 + GameConstants.Instance.D10;
            this.Cost = 8;
            this.Type = "Fire";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Firara at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
