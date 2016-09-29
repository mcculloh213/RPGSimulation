using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McCullough.RPGAttacks
{
    public class GameConstants
    {
        // Chance is 1/DodgeDifficulty, so increasing number are more difficult.
        private const int dodgeDifficulty = 5;

        // Dice, damage bonuses, and multipliers
        private const int plus1 = 1;
        private const int plus2 = 2;
        private const int plus3 = 3;
        private const int plus4 = 4;
        private const int plus5 = 5;
        private const int plus6 = 6;
        private const int d3 = 3;
        private const int d4 = 4;
        private const int d6 = 6;
        private const int d8 = 8;
        private const int d10 = 10;
        private const int d12 = 12;
        private const int d20 = 20;
        private const int mult1 = 1;
        private const int mult2 = 2;
        private const int mult3 = 3;
        private const int mult4 = 4;

        // Health and Magic
        private const int playerHP = 50;
        private const int playerMP = 25;
        
        // Static member variable 'instance'
        private static GameConstants instance = new GameConstants();

        public int DodgeDifficulty
        {
            get { return dodgeDifficulty; }
        }

        public int Plus1
        {
            get { return plus1; }
        }

        public int Plus2
        {
            get { return plus2; }
        }

        public int Plus3
        {
            get { return plus3; }
        }

        public int Plus4
        {
            get { return plus4; }
        }

        public int Plus5
        {
            get { return plus5; }
        }

        public int Plus6
        {
            get { return plus6; }
        }

        public int D3
        {
            get { return d3; }
        }

        public int D4
        {
            get { return d4; }
        }

        public int D6
        {
            get { return d6; }
        }

        public int D8
        {
            get { return d8; }
        }

        public int D10
        {
            get { return d10; }
        }

        public int D12
        {
            get { return d12; }
        }

        public int D20
        {
            get { return d20; }
        }

        public int Mult1
        {
            get { return mult1; }
        }

        public int Mult2
        {
            get { return mult2; }
        }

        public int Mult3
        {
            get { return mult3; }
        }

        public int Mult4
        {
            get { return mult4; }
        }

        public int PlayerHP
        {
            get { return playerHP; }
        }

        public int PlayerMP
        {
            get { return playerMP; }
        }

        // Default Constructor
        private GameConstants()
        {
        }

        // Static member property
        public static GameConstants Instance
        {
            get { return instance; }
        }

    }
}
