using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGSpecial
{
    public class SpecialBase : ISpecial
    {
        public virtual void Special(ICharacter user, ICharacter target)
        {
            Console.WriteLine(user.Name + " stands there blankly.");
        }
    }
}
