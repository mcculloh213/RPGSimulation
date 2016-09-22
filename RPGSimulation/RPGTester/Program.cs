using McCullough.RPGInterfaces;
using McCullough.RPGClasses;
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
            // private IList<ICharacter> playerParty = new List<ICharacter>();
            ICharacter player1 = new Mage("Gandelf");
            ICharacter player2 = new Warrior("Boromir");

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            player1.PerformAttack(player2);

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            player2.PerformAttack(player1);

            Console.ReadLine();
        }
    }
}
