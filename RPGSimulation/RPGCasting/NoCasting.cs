using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;

namespace McCullough.RPGCasting
{
    public class NoCasting : CastingBase
    {
        public override void Cast(ICharacter caster, ICharacter target)
        {
            Console.WriteLine(caster.Name + " attempted some magic, but failed.");
            // base.Cast(caster, target);
        }
    }
}
