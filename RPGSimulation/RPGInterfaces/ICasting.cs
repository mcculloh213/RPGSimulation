using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGInterfaces
{
    public interface ICasting
    {
        int Die { get; }
        int Cost { get; }
        string Type { get; }

        // Methods
        void Cast(ICharacter caster, ICharacter target);
        void Heal(ICharacter caster, ICharacter target);
    }
}
