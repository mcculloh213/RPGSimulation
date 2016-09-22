using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGAttacks
{
    class SpecialAttack : IAttack
    {
        protected Random randomNumbers = new Random();

        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage;
            int roll = randomNumbers.Next(GameConstants.Instance.D20);

            if (roll == 20)
            {
                damage = (GameConstants.Instance.Plus6 +
                    randomNumbers.Next(GameConstants.Instance.D12)) *
                    GameConstants.Instance.Mult4;
            }
            else if (roll >= 18 && roll < 20)
            {
                damage = (GameConstants.Instance.Plus6 +
                    randomNumbers.Next(GameConstants.Instance.D12)) *
                    GameConstants.Instance.Mult4;
            }
            else
            {
                damage = GameConstants.Instance.Plus6 +
                    randomNumbers.Next(GameConstants.Instance.D12);
            }
            target.ReceiveAttack(damage);
        }
    }
}
