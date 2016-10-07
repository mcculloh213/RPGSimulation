using McCullough.RPGClasses;
using McCullough.RPGInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGClassLookup
{
    public class ClassLookup
    {
        /// <summary>
        /// Lookup table for charater auto battle move probabilities. Sum of the elements of the probability array are 100.
        /// {CHARACTER CLASS, [ATTACK, CASTING, SPECIAL]}
        /// </summary>
        protected static Dictionary<string, int[]> mvprob = new Dictionary<string, int[]>
        {
            { "Archer", new int[] { 80, 15, 5 } },
            { "Barbarian", new int[] {80, 5, 15} },
            { "Bard", new int[] { } },
            { "Black Mage", new int[] { } },
            { "Cactuar", new int[] { 10, 0, 90 } },
            { "Computer Wizard", new int[] { 50, 40, 10 } },
            { "Cleric", new int[] { } },
            { "Goblin", new int[] { } },
            { "Mage", new int[] { 20, 75, 5 } },
            { "Monk", new int[] { } },
            { "Red Mage", new int[] { } },
            { "Tonberry", new int[] {100, 0, 0} },
            { "Troll", new int[] { } },
            { "Warrior", new int[] { 80, 5, 15} },
            { "White Mage", new int[] { } }
        };

        /// <summary>
        /// Lookup table for character indexing
        /// </summary>
        protected static Dictionary<int, ICharacter> chlookup = new Dictionary<int, ICharacter>
        {
            // ERROR MACRO
            { 0x000000, new ERMAC() },
            // User Characters -- offset 0 (0x000000)
            { 0x000001, new Archer() },
            { 0x000002, new Barbarian() },
            { 0x000003, new Bard() },
            { 0x000004, new BlackMage() },
            { 0x000005, new Cleric() },
            { 0x000006, new ComputerWizard() },
            { 0x000007, new Druid() },
            { 0x000008, new Fighter() },
            { 0x000009, new Mage() },
            { 0x00000a, new Monk() },
            { 0x00000b, new Paladin() },
            { 0x00000c, new Ranger() },
            { 0x00000d, new RedMage() },
            { 0x00000e, new Rogue() },
            { 0x00000f, new Sorcerer() },
            { 0x000010, new Warlock() },
            { 0x000011, new Warrior() },
            { 0x000012, new WhiteMage() },
            { 0x000013, new Wizard() },
            // ERROR MACRO
            { 0x001000, new ERMAC() },
            // Enemy Characters -- offset 4,096 (0x001000)
            { 0x001001, new Cactuar() },
            { 0x001002, new Goblin() },
            { 0x001003, new Tonberry() },
            { 0x001004, new Troll() }
        };

        private static ClassLookup instance = new ClassLookup();
        public int[] GetValue(string cclass)
        {
            return mvprob[cclass];
        }
        private ClassLookup()
        {

        }
        public static ClassLookup Instance
        {
            get { return instance; }
        }
    }
}
