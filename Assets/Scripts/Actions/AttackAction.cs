public class AttackAction : Action
{
    public AttackAction(IAttack attacker, IDamageable defender)
    {
        command = new AttackCommand(attacker, defender);
    }
}