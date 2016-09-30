using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class LeatherArmor : NormalDefense
    {
        public override void Defend(ICharacter defender, int damage, int armorClass = 10)
        {
            base.Defend(defender, damage, armorClass);
        }
    }
}
