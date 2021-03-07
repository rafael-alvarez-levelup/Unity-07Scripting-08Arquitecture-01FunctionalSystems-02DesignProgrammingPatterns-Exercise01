using UnityEngine;
using UnityEngine.UI;

public class PlayerActionController : MonoBehaviour, IActionController
{
    [SerializeField] private Sprite defaultIcon;

    private ActionBase[] actions;
    private ActionBase currentAction;
    private ISetIcon setIconBehaviour;
    private int index = 0;
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => ChangeAction());

        setIconBehaviour = GetComponentInChildren<ISetIcon>();
        actions = GetComponents<ActionBase>();
    }

    public void ChangeAction()
    {
        index = (index + 1) % actions.Length;
        currentAction = actions[index];
        setIconBehaviour.SetIcon(currentAction.Icon);
    }

    public ICommand GetCurrentCommand()
    {
        return currentAction.Command;
    }

    public void ResetAction()
    {
        currentAction = null;
        index = 0;
        setIconBehaviour.SetIcon(defaultIcon);
    }
}