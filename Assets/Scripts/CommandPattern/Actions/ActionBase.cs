using UnityEngine;

public abstract class ActionBase : MonoBehaviour
{
    public Sprite Icon => icon;

    public ICommand Command { get; protected set; }

    [SerializeField] private Sprite icon;
}