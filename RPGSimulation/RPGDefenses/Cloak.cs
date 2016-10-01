using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class Cloak : NormalDefense
    {
        public Cloak()
        {
            this.armorClass = GameConstants.Instance.D4;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            base.Defend(defender, damage);
        }
    }
}
