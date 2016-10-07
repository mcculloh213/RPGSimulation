using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Blizzara : CastingBase
    {
        public Blizzara()
        {
            this.Die = GameConstants.Instance.D20 + GameConstants.Instance.D10;
            this.Cost = 8;
            this.Type = "Ice";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Blizzara at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
