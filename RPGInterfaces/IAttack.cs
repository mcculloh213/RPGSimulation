namespace McCullough.RPGInterfaces
{
    public interface IAttack
    {
        // Methods
        void Attack(ICharacter attacker, ICharacter target);
        void FixedAttack(ICharacter attacker, ICharacter target, int damage);
    }
}
