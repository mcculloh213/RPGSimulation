using McCullough.RPGGameConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;

namespace McCullough.RPGDefenses
{
    public class High : NormalDefense
    {
        public High()
        {
            this.armorClass = GameConstants.Instance.D100;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            base.Defend(defender, damage);
        }
    }
}
