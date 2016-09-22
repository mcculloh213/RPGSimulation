using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    class NormalAttack : IAttack
    {
        protected Random randomNumbers = new Random();

        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage = GameConstants.Instance.Plus5 +
                randomNumbers.Next(GameConstants.Instance.D10);
            target.ReceiveAttack(damage);
        }
    }
}
