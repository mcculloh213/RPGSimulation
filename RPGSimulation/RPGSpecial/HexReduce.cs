using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.LCRNG;

namespace McCullough.RPGSpecial
{
    public class HexReduce : SpecialBase
    {
        public override void Special(ICharacter user, ICharacter target)
        {
            Console.WriteLine(user.Name + " went into the code for " + target.Name + ".");
            int hex = LCRNG32.Instance.Next(0xF);
            if (hex % 3 == 0)
            {
                Console.WriteLine(target.Name + "'s health dropped by " + hex + "!");
                target.ChangeHealth(hex, '-');
            }
            else if (hex % 3 == 1)
            {
                Console.WriteLine(target.Name + "'s was replaced with " + hex + "!");
                target.ChangeHealth(hex, '=');
            }
            else // hex % 3 == 2
            {
                Console.WriteLine(target.Name + "'s health was modded by " + hex + "!");
                target.ChangeHealth(hex, '%');
            }
        }
    }
}
