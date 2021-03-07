public class HealAction : ActionBase
{
    private void Awake()
    {
        Command = new HealCommand(GetComponent<IHeal>());
    }
}