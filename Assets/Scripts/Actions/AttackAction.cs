using UnityEngine;

public class AttackAction : ActionBase
{
    public AttackAction(IAttack attacker, IDamageable target)
    {
        sprite = Resources.Load<Sprite>("attack_normal");
        command = new AttackCommand(attacker, target);
    }
}