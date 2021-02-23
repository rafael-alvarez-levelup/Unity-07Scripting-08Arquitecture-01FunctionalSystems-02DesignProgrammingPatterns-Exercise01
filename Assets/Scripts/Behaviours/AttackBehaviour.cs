using UnityEngine;

public class AttackBehaviour : MonoBehaviour, IAttack
{
    [SerializeField] private int damage = 10;

    public void Attack(IDamageable target)
    {
        target.TakeDamage(damage);
    }
}