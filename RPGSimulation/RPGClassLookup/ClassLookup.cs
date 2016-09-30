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
        /// Lookup table for charater auto battle move probabilities.
        /// {CHARACTER CLASS, [ATTACK, CASTING, SPECIAL]}
        /// </summary>
        protected static Dictionary<string, int[]> lookup = new Dictionary<string, int[]>
        {
            { "Archer", new int[] { 80, 15, 5 } },
            { "Cactuar", new int[] { 10, 0, 90 } },
            { "Computer Wizard", new int[] { 50, 40, 10 } },
            { "Mage", new int[] { 20, 75, 5 } },
            { "Warrior", new int[] { 80, 5, 15} }
        };

        private static ClassLookup instance = new ClassLookup();
        public int[] GetValue(string cclass)
        {
            return lookup[cclass];
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
