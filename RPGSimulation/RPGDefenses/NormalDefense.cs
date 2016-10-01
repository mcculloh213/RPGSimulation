using McCullough.LCRNG;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGDefenses
{
    public class NormalDefense : IDefense
    {
        public int armorClass
        {
            get;
            protected set;
        }

        public virtual void Defend(ICharacter defender, int damage)
        {
            int reduction = LCRNG32.Instance.Next(armorClass);
            int ndamage = damage - reduction;
            if (ndamage < 0) ndamage = 0;
            // Console.WriteLine("Damage reduced by {0}!", reduction);
            defender.ReceiveAttack(ndamage);
        }
    }
}
