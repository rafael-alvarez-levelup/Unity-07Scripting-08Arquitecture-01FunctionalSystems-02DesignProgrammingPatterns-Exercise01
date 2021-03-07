public class AttackAction : ActionBase
{
    private void Awake()
    {
        Command = new AttackCommand(GetComponent<IAttack>());
    }
}