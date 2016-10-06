using McCullough.RPGGameConstants;
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
        public MetalArmor()
        {
            this.armorClass = GameConstants.Instance.D20 + GameConstants.Instance.D12 + GameConstants.Instance.D3;
        }
        public override void Defend(ICharacter defender, int damage)
        {
            base.Defend(defender, damage);
        }
    }
}
