using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;

namespace McCullough.RPGCasting
{
    public class Fire : CastingBase
    {
        public Fire()
        {
            this.Die = GameConstants.Instance.D10;
            this.Cost = 4;
            this.Type = "Fire";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Fire at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
