using McCullough.RPGGameConstants;
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
        public MediumShield()
        {
            this.armorClass = GameConstants.Instance.D12 + GameConstants.Instance.D10 + GameConstants.Instance.D3;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            Console.WriteLine(defender.Name + " readies their medium shield!");
            base.Defend(defender, damage);
        }
    }
}
