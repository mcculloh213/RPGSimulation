using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class MediumShield : NormalDefense
    {
        public override void Defend(ICharacter defender, int damage, int armorClass = 25)
        {
            Console.WriteLine(defender.Name + " readies their medium shield!");
            base.Defend(defender, damage, armorClass);
        }
    }
}
