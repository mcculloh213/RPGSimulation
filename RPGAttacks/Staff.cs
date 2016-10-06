using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGAttacks
{
    public class Staff : NormalAttack
    {
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            Console.WriteLine(attacker.Name + " clubs " +
                target.Name + "!");
            base.Attack(attacker, target);
        }
    }
}
