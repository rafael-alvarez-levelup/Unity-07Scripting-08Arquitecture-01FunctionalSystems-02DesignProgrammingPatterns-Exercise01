using UnityEngine;

public class HealBehaviour : MonoBehaviour, IHealable
{
    public void Heal()
    {
        print($"Heal {gameObject}");
    }
}
