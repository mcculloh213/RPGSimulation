using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class MetalArmor : NormalDefense
    {
        public override void Defend(ICharacter defender, int damage, int armorClass = 35)
        {
            base.Defend(defender, damage, armorClass);
        }
    }
}
