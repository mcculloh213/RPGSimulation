using McCullough.RPGInterfaces;
using McCullough.RPGClasses;
using McCullough.RPGCombat;
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
        static void Main(string[] args)
        {
            IList<ICharacter> playerParty = new List<ICharacter>();
            IList<ICharacter> enemyParty = new List<ICharacter>();
            ICharacter player1 = new Mage("Gandelf");
            ICharacter player2 = new Warrior("Boromir");
            ICharacter player3 = new Cactuar("Cactuar 0");
            ICharacter player4 = new Cactuar("Cactuar 1");
            ICharacter player5 = new Cactuar("Cactuar 2");
            playerParty.Add(player1);
            playerParty.Add(player2);
            enemyParty.Add(player3);
            enemyParty.Add(player4);
            enemyParty.Add(player5);
            Combat cbat = new Combat(playerParty, enemyParty, "Player Party", "Enemy Party");
            cbat.AutoBattle();

            // LCRNG32 lcrng = new LCRNG32();
            // for (int i = 0; i < 1000; i++)
            // {
            //     Console.WriteLine("Seed={0} -- Value={1}", lcrng.ToString(), lcrng.Next(20));
            // }
            //
            // Console.WriteLine(player1);
            // Console.WriteLine(player2);
            //
            // player1.PerformAttack(player2);
            //
            // Console.WriteLine(player1);
            // Console.WriteLine(player2);
            //
            // player2.PerformAttack(player1);
            //
            // Console.ReadLine();

        }
    }
}
