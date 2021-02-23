using UnityEngine;

public class DefendBehaviour : MonoBehaviour, IDefendable
{
    public void Defend()
    {
        print($"Defend {gameObject}");
    }
}