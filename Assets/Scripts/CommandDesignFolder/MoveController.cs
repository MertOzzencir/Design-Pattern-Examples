using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController
{

    private Stack<ICommand> commands;

    public MoveController()
    {
        commands = new Stack<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        command.Execute();
        commands.Push(command);
    }


    public void UndoCommand()
    {
        if (commands.Count != 0)
        {
            commands.Pop().Undo();

        }

    }

}
