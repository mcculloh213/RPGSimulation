using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using McCullough.RPGInterfaces;
using McCullough.LCRNG;

namespace McCullough.RPGAttacks
{
    public class ChefKnife : SpecialAttack
    {
        protected int step = 0;
        public override void Attack(ICharacter attacker, ICharacter target)
        {
            if (step >= 5)
            {
                int roll = LCRNG32.Instance.Next(100);
                if (roll % step >= 3)
                {
                    Console.WriteLine(attacker.Name + " stabs at " + target.Name + "!");
                    base.Attack(attacker, target);
                    Console.WriteLine(attacker.Name + " moves back.");
                    step = 0;
                }
                else
                {
                    Console.WriteLine(attacker.Name + " tripped.");
                    step++;
                }
                
            }
            else
            {
                Console.WriteLine(attacker.Name + " takes a step closer.");
                step++;
            }
            
        }
    }
}
