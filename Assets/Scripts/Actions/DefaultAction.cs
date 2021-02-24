using UnityEngine;

public class DefaultAction : ActionBase
{
    public DefaultAction(IDefaultable defaulter)
    {
        sprite = Resources.Load<Sprite>("slot_empty");
        command = new DefaultCommand(defaulter);
    }
}