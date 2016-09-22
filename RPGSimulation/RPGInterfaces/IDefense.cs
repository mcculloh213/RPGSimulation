using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGInterfaces
{
    interface IDefense
    {
        // Methods
        void Defend(ICharacter defender);
    }
}
