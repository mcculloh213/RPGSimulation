using McCullough.LCRNG;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCasting
{
    public class CastingBase : ICasting
    {
        public int Die
        {
            get;
            protected set;
        }

        public int Cost
        {
            get;
            protected set;
        }

        public string Type
        {
            get;
            protected set;
        }

        public virtual void Cast(ICharacter caster, ICharacter target)
        {
            int damage = LCRNG32.Instance.Next(Die);
            target.ReceiveAttack(damage);
            caster.ReduceMagic(Cost);
        }

        public void Heal(ICharacter caster, ICharacter target)
        {
            int factor = LCRNG32.Instance.Next(Die);
            target.ChangeHealth(factor, '+');
            caster.ReduceMagic(Cost);
        }
    }
}
