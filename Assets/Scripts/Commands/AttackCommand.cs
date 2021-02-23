public class AttackCommand : ICommand
{
    private readonly IAttack attacker;
    private readonly IDamageable defender;

    public AttackCommand(IAttack attacker, IDamageable defender)
    {
        this.attacker = attacker;
        this.defender = defender;
    }

    public void Execute()
    {
        attacker.Attack(defender);
    }
}