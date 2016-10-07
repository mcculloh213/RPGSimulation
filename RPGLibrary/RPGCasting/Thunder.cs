using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Thunder : CastingBase
    {
        public Thunder()
        {
            this.Die = GameConstants.Instance.D10;
            this.Cost = 4;
            this.Type = "Electric";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Thunder at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
