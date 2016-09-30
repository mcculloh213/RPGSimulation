using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;

namespace McCullough.RPGSpecial
{
    public class NoSpecial : SpecialBase
    {
        public override void Special(ICharacter user, ICharacter target)
        {
            base.Special(user, target);
        }
    }
}
