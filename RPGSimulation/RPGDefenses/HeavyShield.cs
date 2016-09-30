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
        public override void Defend(ICharacter defender, int damage, int armorClass = 40)
        {
            Console.WriteLine(defender.Name + " readies their heavy shield!");
            base.Defend(defender, damage, armorClass);
        }
    }
}
