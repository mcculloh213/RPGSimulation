using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class HeavyShield : NormalDefense
    {
        public HeavyShield()
        {
            this.armorClass = 2 * GameConstants.Instance.D20;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            Console.WriteLine(defender.Name + " readies their heavy shield!");
            base.Defend(defender, damage);
        }
    }
}
