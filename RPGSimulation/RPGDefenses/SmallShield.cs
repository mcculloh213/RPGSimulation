using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.RPGAttacks;
using McCullough.RPGGameConstants;

namespace McCullough.RPGDefenses
{
    public class SmallShield : NormalDefense
    {
        public SmallShield()
        {
            this.armorClass = GameConstants.Instance.D10;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            Console.WriteLine(defender.Name + " readies their small shield!");
            base.Defend(defender, damage);
        }
    }
}
