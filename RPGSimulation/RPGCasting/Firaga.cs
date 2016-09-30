using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Firaga : CastingBase
    {
        public Firaga()
        {
            this.Die = GameConstants.Instance.D100;
            this.Cost = 8;
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Firaga at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
