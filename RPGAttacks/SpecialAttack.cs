using McCullough.LCRNG;
using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGAttacks
{
    public class SpecialAttack : IAttack
    {
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage;
            int roll = LCRNG32.Instance.Next(GameConstants.Instance.D20);

            if (roll == 20)
            {
                damage = (GameConstants.Instance.Plus6 +
                    LCRNG32.Instance.Next(GameConstants.Instance.D12)) *
                    GameConstants.Instance.Mult4;
            }
            else if (roll >= 18 && roll < 20)
            {
                damage = (GameConstants.Instance.Plus6 +
                    LCRNG32.Instance.Next(GameConstants.Instance.D12)) *
                    GameConstants.Instance.Mult2;
            }
            else
            {
                damage = GameConstants.Instance.Plus6 +
                    LCRNG32.Instance.Next(GameConstants.Instance.D12);
            }
            roll = LCRNG32.Instance.Next(GameConstants.Instance.D100);
            if (roll >= 60) // 40% chance to defend
            {
                target.PerformDefend(target, damage);
            }
            else
            {
                target.ReceiveAttack(damage);
            }
        }

        public void FixedAttack(ICharacter attacker, ICharacter target, int damage)
        {
            int roll = LCRNG32.Instance.Next(GameConstants.Instance.D100);
            if (roll >= 60) // 40% chance to defend
            {
                target.PerformDefend(target, damage);
            }
            else
            {
                target.ReceiveAttack(damage);
            }
        }
    }
}
