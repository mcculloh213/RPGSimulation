using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.LCRNG;
using McCullough.RPGGameConstants;

namespace McCullough.RPGSpecial
{
    public class KeenEye : SpecialBase
    {
        public override void Special(ICharacter user, ICharacter target)
        {
            Console.WriteLine(user.Name + " takes careful aim.");
            int roll = LCRNG32.Instance.Next(GameConstants.Instance.D20);
            Console.WriteLine(target.Name + " takes substantial damage!");
            if (roll >= 18)
            {
                target.ChangeHealth(target.Health, '-');
            }
            else
            {
                target.ChangeHealth((target.Health / 2), '-');
            }
        }
    }
}
