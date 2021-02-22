using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour, ICommandProcessor
{
    private Stack<ICommand> commandStack;

    public void Process(ICommand command)
    {
        commandStack.Push(command);
        command.Execute();
    }
}