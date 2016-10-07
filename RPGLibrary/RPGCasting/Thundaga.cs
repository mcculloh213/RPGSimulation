using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class Thundaga : CastingBase
    {
        public Thundaga()
        {
            this.Die = GameConstants.Instance.D100;
            this.Cost = 16;
            this.Type = "Electric";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Thundaga at " +
                target.Name + "!");
            base.Cast(attacker, target);
        }
    }
}
