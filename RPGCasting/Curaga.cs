using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    class Curaga : CastingBase
    {
        public Curaga()
        {
            this.Die = GameConstants.Instance.D100;
            this.Cost = 16;
            this.Type = "Healing";
        }

        public override void Cast(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " casts Curaga on " +
                target.Name + "!");
            base.Heal(attacker, attacker);
        }
    }
}
