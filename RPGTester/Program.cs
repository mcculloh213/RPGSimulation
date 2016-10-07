using McCullough.RPGInterfaces;
using McCullough.RPGClasses;
using McCullough.RPGCombat;
using McCullough.RPGClassLookup;
using McCullough.LCRNG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGCore
{
    class Program
    {
        public static IList<ICharacter> generateParty()
        {
            IList<ICharacter> party = new List<ICharacter>();
            for (int i = 0; i < 5; i++) {
                int chcode = LCRNG32.Instance.Next(0x18);
                ICharacter member = ClassLookup.Instance.Lookup(chcode);
                party.Add(member);
            }
            return party;
        }

        static void Main(string[] args)
        {
            IList<ICharacter> playerParty = generateParty();
            IList<ICharacter> enemyParty = generateParty();
            Combat cbat = new Combat(playerParty, enemyParty, "Player Party", "Enemy Party");
            cbat.AutoBattle();
        }
    }
}
