namespace McCullough.RPGInterfaces
{
    public interface ICharacter
    {
        // Properties
        string CharacterClass { get; }
        string Name { get; }
        int Health { get; }
        int Magic { get; }
        int CharacterDie { get; }
        int Dodge { get; }
        IAttack AttackBehavior { get; }
        ICasting SpellBehavior { get; }
        ISpecial SpecialBehavior { get; }
        IDefense DefenseBehavior { get; }

        // Methods
        void PerformAttack(ICharacter target);
        void PerformSpell(ICharacter target);
        void PerformSpecial(ICharacter target);
        void PerformDefend(ICharacter defender, int damage);
        void ReceiveAttack(int damage);
        void ReduceMagic(int reduction);
        void ChangeHealth(int factor, char op);
    }
}
