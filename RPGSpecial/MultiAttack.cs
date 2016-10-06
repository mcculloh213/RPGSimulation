using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.LCRNG;

namespace McCullough.RPGSpecial
{
    public class MultiAttack : SpecialBase
    {
        public override void Special(ICharacter user, ICharacter target)
        {
            Console.WriteLine(user.Name + " uses Multi Attack!");
            int attacks = LCRNG32.Instance.Next(user.CharacterDie);
            for (int i = 0; i < attacks; i++)
            {
                user.PerformAttack(target);
            }
        }
    }
}
