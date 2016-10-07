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
        // TODO: There needs to be some serious rebalancing after I've got everything up and running.
        /// <summary>
        /// Lookup table for charater auto battle move probabilities. Sum of the elements of the probability array are 100.
        /// {CHARACTER CLASS, [ATTACK, CASTING, SPECIAL]}
        /// </summary>
        protected static Dictionary<string, int[]> mvprob = new Dictionary<string, int[]>
        {                                                                 // ATT | CAS | SPE 
            { "Archer", new int[] { 80, 15, 5 } },                        //  80 |   5 |  15
            { "Barbarian", new int[] { 80, 5, 15 } },                     //  80 |  15 |   5
            { "Bard", new int[] { 100, 0, 0 } },                          // 100 |   0 |   0
            { "Black Mage", new int[] { 50, 50, 0 } },                    //  50 |  50 |   0
            { "Cactuar", new int[] { 10, 0, 90 } },                       //  10 |   0 |  90
            { "Cleric", new int[] { 80, 20, 0 } },                        //  80 |  20 |   0
            { "Computer Wizard", new int[] { 50, 40, 10 } },              //  50 |  40 |  10
            { "Druid", new int[] { 75, 25, 0 } },                         //  75 |  25 |   0
            { "ERMAC", new int[] { 100, 0, 0 } },                         // 100 |   0 |   0
            { "Fighter", new int[] { 100, 0, 0 } },                       // 100 |   0 |   0
            { "Goblin", new int[] { 100, 0, 0 } },                        // 100 |   0 |   0
            { "Mage", new int[] { 20, 75, 5 } },                          //  20 |  75 |   5
            { "Monk", new int[] { 70, 30, 0 } },                          //  70 |  30 |   0
            { "Paladin", new int[] { 60, 30, 10 } },                      //  60 |  30 |  10
            { "Ranger", new int[] { 80, 0, 20} },                         //  80 |   0 |  20
            { "Red Mage", new int[] { 50, 50, 0 } },                      //  50 |  50 |   0
            { "Rogue", new int[] { 50, 10, 40 } },                        //  50 |  10 |  40
            { "Sorcerer", new int[] { 50, 50, 0 } },                      //  50 |  50 |   0
            { "Tonberry", new int[] { 100, 0, 0 } },                      // 100 |   0 |   0
            { "Troll", new int[] { 100, 0, 0 } },                         // 100 |   0 |   0
            { "Warlock", new int[] { 50, 50, 0 } },                       //  50 |  50 |   0
            { "Warrior", new int[] { 80, 5, 15 } },                       //  80 |   5 |  15
            { "White Mage", new int[] { 50, 50, 0 } },                    //  50 |  50 |   0
            { "Wizard", new int[] { 50, 50, 0 } }                         //  50 |  50 |   0
        };

        /// <summary>
        /// Lookup table for character indexing
        /// </summary>
        protected static Dictionary<int, ICharacter> chlookup = new Dictionary<int, ICharacter>
        {
            // ERROR MACRO
            { 0x00, new ERMAC() },
            // User Characters -- offset 0 (0x00)
            { 0x01, new Archer() },
            { 0x02, new Barbarian() },
            { 0x03, new Bard() },
            { 0x04, new BlackMage() },
            { 0x05, new Cleric() },
            { 0x06, new ComputerWizard() },
            { 0x07, new Druid() },
            { 0x08, new Fighter() },
            { 0x09, new Mage() },
            { 0x0a, new Monk() },
            { 0x0b, new Paladin() },
            { 0x0c, new Ranger() },
            { 0x0d, new RedMage() },
            { 0x0e, new Rogue() },
            { 0x0f, new Sorcerer() },
            { 0x10, new Warlock() },
            { 0x11, new Warrior() },
            { 0x12, new WhiteMage() },
            { 0x13, new Wizard() },
            // ERROR MACRO
            { 0x14, new ERMAC("ERMAC") },
            // Enemy Characters -- offset 20 (0x14)
            { 0x15, new Cactuar("Cactuar", 25, -1) },
            { 0x16, new Goblin() },
            { 0x17, new Tonberry("Tonberry", 100, -1) },
            { 0x18, new Troll() },
            { 0x19, null },
            { 0x1a, null },
            { 0x1b, null },
            { 0x1c, null },
            { 0x1d, null },
            { 0x1e, null },
            { 0x1f, null },
            { 0x20, null },
            { 0x21, null },
            { 0x22, null },
            { 0x23, null },
            { 0x24, null },
            { 0x25, null },
            { 0x26, null },
            { 0x27, null },
            { 0x28, null },
            { 0x29, null },
            { 0x2a, null },
            { 0x2b, null },
            { 0x2c, null },
            { 0x2d, null },
            { 0x2e, null },
            { 0x2f, null },
        };

        protected static string[] PlayerNames = new string[]
        {
            // Male
            "Uhland",
            "Wilfred",
            "Nikhil",
            "Sami",
            "Theobald",
            "Zander",
            "Theodoric",
            "Louie",
            "Clayton",
            "Radford",
            "Edvard",
            "Juanito",
            "Winthrop",
            "Alvertos",
            "Rudolfo",
            "Michail",
            "Darren",
            "Mick",
            "Edwin",
            "Linn",
            "Demarcus",
            "Farald",
            "Brook",
            "Everette",
            "Darion",
            "Jaiden",
            "Howard",
            "Pascal",
            "Valerio",
            "Leodegrance",
            "Rylee",
            // Female
            "Grete",
            "Genevie",
            "Alva",
            "Perla",
            "Silvana",
            "Nesrin",
            "Franzi",
            "Sydnie",
            "Marjolaina",
            "Clementine",
            "Montana",
            "Rut",
            "Laverne",
            "Trudy",
            "Bella",
            "Claiborne",
            "Moni",
            "Margareta",
            "Elberta",
            "Vignette",
            "Ethel",
            "Scarlet",
            "Devondra",
            "Keyla",
            "Verena",
            "Amata",
            "Karlee",
            "Blondell",
            "Gretti",
            "Lorelie",
            "Maya",
            "Viktorine"
        };

        private static ClassLookup instance = new ClassLookup();
        public int[] GetValue(string cclass)
        {
            return mvprob[cclass];
        }
        public ICharacter Lookup(int lookup)
        {
            return chlookup[lookup];
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
