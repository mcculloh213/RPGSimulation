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
        public LeatherArmor()
        {
            this.armorClass = 10;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            base.Defend(defender, damage);
        }
    }
}
