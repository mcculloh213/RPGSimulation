using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGInterfaces
{
    public interface ICasting
    {
        // Methods
        void Cast(ICharacter caster, ICharacter target);
    }
}
