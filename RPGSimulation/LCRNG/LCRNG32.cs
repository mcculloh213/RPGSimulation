using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.LCRNG
{
    public class LCRNG32
    {
        protected int seed;
        public static LCRNG32 instance = new LCRNG32();

        private LCRNG32()
        {
            Random rng = new Random();
            seed = rng.Next(0, 0xfffffff);
        }

        public static LCRNG32 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Generate a pseudo-random number based on the current seed
        /// </summary>
        /// <param name="modulus">The "die" to be used.</param>
        /// <returns>An integer in the range [0, modulus].</returns>
        public int Next(int modulus)
        {
            int result;
            int n_seed = unchecked(0x41c64e6d * seed + 0x00006073);
            if (n_seed < 0)
            {
                n_seed *= -1;
            }
            result = seed % (modulus + 1);
            seed = n_seed;
            return result;
        }

        public override string ToString()
        {
            return seed.ToString("X");
        }
    }
}
