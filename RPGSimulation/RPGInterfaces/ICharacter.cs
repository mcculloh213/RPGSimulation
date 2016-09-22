namespace McCullough.RPGInterfaces
{
    public interface ICharacter
    {
        // Properties
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }
        int Magic { get; }

        // Methods
        void PerformAttack(ICharacter target);
        void PerformSpell(ICharacter target);
        void ReceiveAttack(int damage);
    }
}
