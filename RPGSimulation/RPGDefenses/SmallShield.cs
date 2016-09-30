using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.RPGAttacks;

namespace McCullough.RPGDefenses
{
    public class SmallShield : NormalDefense
    {
        public override void Defend(ICharacter defender, int damage, int armorClass = 10)
        {
            Console.WriteLine(defender.Name + " readies their small shield!");
            base.Defend(defender, damage, armorClass);
        }
    }
}
