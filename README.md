# RPGSimulation
The Ohio State University: CSE 4253 C# RPG Simulation Project

## LCRNG `RPGSimulation/LCRNG`
32-bit Linear Congruential Random Number Generator (LCRNG32) initiates a random seed between 0 and 0xFFFFFFF, then generates consecutive seeds using the formula: `0x41C64E6D * seed + 0x00006073`. Should the new seed be a negative number, because it doesn't fit in 32-bits, the new seed is multiplied by -1. The number returned is based off of one passed parameter, using the formula: `seed % (modulus + 1)`, which gives a number in the range [0, modulus], effectively mimicing a random die throw.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* LCRNG.csproj
* LCRNG32.cs

## RPGAttacks `RPGSimulation/RPGAttacks`
Dynamic-Link Library containing definitions for all attacks used by classes.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* BadGradeAttack.cs
* BowAttack.cs
* ChefKnife.cs
* FireAttack.cs
* NormalAttack.cs : `IAttack`
* OneThousandNeedles.cs
* RPGAttacks.csproj
* SpecialAttack.cs : `IAttack`
* Staff.cs
* SwordAttack.cs

## RPGCasting `RPGSimulation/RPGCasting`
Dynamic-Link Library containing definitions for all spells used by classes.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* Blizzaga.cs
* Blizzara.cs
* Blizzard.cs
* CastingBase.cs : `ICasting`
* Cura.cs
* Curaga.cs
* Cure.cs
* Fireaga.cs
* Firara.cs
* Fire.cs
* NoCasting.cs
* RPGCasting.csproj
* Thudaga.cs
* Thundara.cs
* Thunder.cs

## RPGClasses `RPGSimulation/RPGClasses`
Dynamic-Link Library containing definitions for all classes.

Directory Contents:
* bin
* obj
* Properties
  * AssemblyInfo.cs
* Archer.cs
* Barbarian.cs
* Bard.cs
* BlackMage.cs
* Cactuar.cs
* CharacterBase : `ICharacter`
* Cleric.cs
* ComputerWizard.cs
* Druid.cs
* ERMAC.cs
* Fighter.cs
* Goblin.cs
* Mage.cs
* Monk.cs
* Paladin.cs
* Ranger.cs
* RedMage.cs
* Rogue.cs
* RPGClasses.csproj
* Sorcerer.cs
* Tonberry.cs
* Troll.cs
* Warlock.cs
* Warrior.cs
* WhiteMage.cs
* Wizard.cs

## RPGClassLookup `RPGSimulation/RPGClassLookup`
Dynamic-Link Library containing a lookup table for all classes.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* ClassLookup.cs
* RPGClassLookup.csproj

## RPGCombat `RPGSimulation/RPGCombat`
Dynamic-Link Library implementing standard combat, and AutoBattle.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* Combat.cs
* RPGCombat.csproj

## RPGDefenses `RPGSimulation/RPGDefenses`
Dynamic-Link Library containing definitions for all defenses used by classes.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* Cloak.cs
* HeavyShield.cs
* High.cs
* LeatherArmor.cs
* MediumShield.cs
* MetalArmor.cs
* NoDefense.cs
* NormalDefense.cs : `IDefense`
* RPGDefenses.csproj
* SmallShield.cs

## RPGGameConstants `RPGSimulation/RPGGameConstants`
Dynamic-Link Library containing game constants.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* GameConstants.cs
* RPGGameConstants.csproj

## RPGInterfaces `RPGSimulation/RPGInterfaces`
Dynamic-Link Library containing interfaces for attacks, casting, classes, combat, special, and defenses.

Directory Contents:
* bin
* obj
* Properties
  * AssemblyInfo.cs
* IAttack.cs
* ICasting.cs
* ICharacter.cs
* ICombat.cs
* IDefense.cs
* ISpecial.cs
* RPGInterfaces.csproj

## RPGSpecial `RPGSimulation/RPGSpecial`
Dynamic-Link Library containing definitions for all specials used by classes.

Directory Contents:
* Properties
  * AssemblyInfo.cs
* HexReduce.cs
* MultiAttack.cs
* NoSpecial.cs
* RPGSpecial.csproj
* SpecialBase.cs : `ISpecial`

## RPGTester `RPGSimulation/RPGTester`
Console based application that simulates AutoBattle.

Directory Contents:
* bin
* obj
* Properties
  * AssemblyInfo.cs
* App.config
* Program.cs
* RPGTester.csproj
