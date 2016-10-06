using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Thundara : CastingBase
    {
        public Thundara()
        {
            this.Die = GameConstants.Instance.D20 + GameConstants.Instance.D10;
            this.Cost = 8;
            this.Type = "Electric";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Thundara at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
