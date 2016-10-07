using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Blizzard : CastingBase
    {
        public Blizzard()
        {
            this.Die = GameConstants.Instance.D10;
            this.Cost = 4;
            this.Type = "Ice";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Blizzard at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
