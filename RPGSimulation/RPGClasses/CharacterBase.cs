﻿using McCullough.LCRNG;
using McCullough.RPGAttacks;
using McCullough.RPGGameConstants;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClasses
{
    public class CharacterBase : ICharacter
    {
        protected const string AnonymousName = "Anonymous";
        protected static int anonymousCounter = 0;
        

        protected IAttack attackBehavior;
        protected ICasting spellBehavior;
        protected ISpecial specialBehavior;
        protected IDefense defenseBehavior;

        public string CharacterClass
        {
            get;
            protected set;
        }

        public int Health
        {
            get;
            protected set;
        }

        public string Name
        {
            get;
            protected set;
        }

        public int Magic
        {
            get;
            protected set;
        }

        public int CharacterDie
        {
            get;
            protected set;
        }

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }

        public virtual void PerformSpell(ICharacter target)
        {
            spellBehavior.Cast(this, target);
        }

        public void PerformSpecial(ICharacter target)
        {
            specialBehavior.Special(this, target);
        }

        public virtual void PerformDefend(ICharacter defender, int dmg)
        {
            defenseBehavior.Defend(defender, dmg);
        }

        public virtual void ReceiveAttack(int damage)
        {
            if (LCRNG32.Instance.Next(GameConstants.Instance.DodgeDifficulty) != 0)
            {
                Console.WriteLine(this.Name + " takes " + damage + " damage.");
                Health -= damage;
                if (Health < 0) Health = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " dodges the attack!");
            }
        }

        public void ReduceMagic(int reduction)
        {
            Magic -= reduction;
            if (Magic < 0) Magic = 0;
        }

        public override string ToString()
        {
            string str;
            if (Magic != -1)
            {
                str = String.Format("{0} the {1} has {2} health", Name, CharacterClass, Health);
            }
            else
            {
                str = String.Format("{0} the {1} has {2} health and {3} MP", Name, CharacterClass, Health, Magic);
            }
            return str;            
        }
    }
}
