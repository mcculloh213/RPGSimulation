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
            ICharacter player1 = new Mage("Gandelf", 38, 40);
            ICharacter player2 = new Warrior("Boromir", 70, 15);
            ICharacter player3 = new Cactuar("Cactuar 0", 20, -1);
            ICharacter player4 = new Cactuar("Cactuar 1", 20, -1);
            ICharacter player5 = new Cactuar("Cactuar 2", 20, -1);
            ICharacter player6 = new Cactuar("Cactuar 3", 20, -1);
            ICharacter player7 = new Cactuar("Cactuar 4", 20, -1);
            ICharacter player8 = new ComputerWizard("FooBar", 64, 64);
            ICharacter player9 = new Tonberry("Tonberry 0", 100, -1);
            ICharacter player10 = new Tonberry("Tonberry 1", 100, -1);
            ICharacter player11 = new Tonberry("Tonberry 2", 100, -1);
            playerParty.Add(player1);
            playerParty.Add(player2);
            playerParty.Add(player8);
            //enemyParty.Add(player3);
            //enemyParty.Add(player4);
            //enemyParty.Add(player5);
            //enemyParty.Add(player6);
            //enemyParty.Add(player7);
            enemyParty.Add(player9);
            enemyParty.Add(player10);
            enemyParty.Add(player11);
            Combat cbat = new Combat(playerParty, enemyParty, "Player Party", "Enemy Party");
            // player1.PerformSpell(player3);
            cbat.AutoBattle();
            Console.WriteLine(player11 is Tonberry);
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
