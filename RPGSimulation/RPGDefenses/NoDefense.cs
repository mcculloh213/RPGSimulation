using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class NoDefense : NormalDefense
    {
        public override void Defend(ICharacter defender, int damage, int armorClass = 0)
        {
            defender.ReceiveAttack(damage);
        }
    }
}
