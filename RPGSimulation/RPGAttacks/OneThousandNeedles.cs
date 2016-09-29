using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;

namespace McCullough.RPGAttacks
{
    public class OneThousandNeedles : SpecialAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " sprayed 1000 Needles at " + target.Name + "!");
            base.FixedAttack(attacker, target, 1000);
        }
    }
}
