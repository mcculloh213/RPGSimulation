# RPGSimulation
The Ohio State University: CSE 4253 C# RPG Simulation Project

## LCRNG `RPGSimulation/LCRNG`
32-bit Linear Congruential Random Number Generator (LCRNG32) initiates a random seed between 0 and 0xFFFFFFF, then generates consecutive seeds using the formula:
	*0x41C64E6D * seed + 0x00006073*
Should the new seed be a negative number, because it doesn't fit in 32-bits, the new seed is multiplied by -1. The number returned is based off of one passed parameter, using the formula:
	*seed % (modulus + 1)*
which gives a number in the range [0, modulus], effectively mimicing a random die throw.

## RPGAttacks `RPGSimulation/RPGAttacks`

## RPGCasting `RPGSimulation/RPGCasting`

## RPGClasses `RPGSimulation/RPGClasses`

## RPGClassLookup `RPGSimulation/RPGClassLookup`

## RPGCombat `RPGSimulation/RPGCombat`

## RPGDefenses `RPGSimulation/RPGDefenses`

## RPGGameConstants `RPGSimulation/RPGGameConstants`

## RPGInterfaces `RPGSimulation/RPGInterfaces`

## RPGSpecial `RPGSimulation/RPGSpecial`

## RPGTester `RPGSimulation/RPGTester`
