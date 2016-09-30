using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGInterfaces
{
    public interface IDefense
    {
        // Methods
        void Defend(ICharacter defender, int damage, int armorClass = 0);
    }
}
