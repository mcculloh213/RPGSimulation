using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    class Blizzaga : CastingBase
    {
        public Blizzaga()
        {
            this.Die = GameConstants.Instance.D100;
            this.Cost = 12;
            this.Type = "Ice";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Blizzaga at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
