﻿using McCullough.LCRNG;
using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGAttacks
{
    public class NormalAttack : IAttack
    {
        public virtual void Attack(ICharacter attacker, ICharacter target)
        {
            int damage;
            int roll = LCRNG32.Instance.Next(GameConstants.Instance.D20);
            if (roll == 20)
            {
                damage = (GameConstants.Instance.Plus5 +
                    LCRNG32.Instance.Next(attacker.CharacterDie)) *
                    GameConstants.Instance.Mult2;
            }
            else
            {
                damage = GameConstants.Instance.Plus5 +
                    LCRNG32.Instance.Next(attacker.CharacterDie);
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

        public virtual void FixedAttack(ICharacter attacker, ICharacter target, int damage)
        {
            int roll = LCRNG32.Instance.Next(GameConstants.Instance.D100);
            if (roll >= 40) // 60% chance to defend
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
