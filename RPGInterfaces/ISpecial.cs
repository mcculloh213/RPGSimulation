using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGInterfaces
{
    public interface ISpecial
    {
        void Special(ICharacter user, ICharacter target);
    }
}
