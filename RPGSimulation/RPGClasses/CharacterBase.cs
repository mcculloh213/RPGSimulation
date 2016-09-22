﻿using McCullough.RPGInterfaces;
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
        protected Random randomNumbers = new Random();

        protected IAttack attackBehavior;

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

        public virtual void PerformAttack(ICharacter target)
        {
            attackBehavior.Attack(this, target);
        }

        public virtual void ReceiveAttack(int damage)
        {
            if (randomNumbers.Next(GameConstants.Instance.DodgeDifficulty) != 0)
            {
                Console.WriteLine(this.Name + " takes " + damage + " damage.");
                Health -= damage;
                if (Health < 0) Health = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " dodges the atatck!");
            }
        }

        public override string ToString()
        {
            return String.Format("{0} the {1} has {2} health", Name, CharacterClass, Health);
        }
    }
}
