﻿namespace VP.DesignPatterns.Command;


/// <summary>
/// Invoker has information about all commands, all executed commands and provides way to execute them or undo them.
/// </summary>
public class Invoker
{
    private readonly Queue<ICommand> _commands = new Queue<ICommand>();
    private readonly Stack<ICommand> _executedCommands = new Stack<ICommand>();


    public void AddCommand(ICommand command)
    {
        _commands.Enqueue(command);
    }


    public void ExecuteCommands()
    {
        while (_commands.Count > 0)
        {
            ICommand command = _commands.Dequeue();
            command.Execute();
            _executedCommands.Push(command);
        }
    }

    public void Undo()
    {
        if (_executedCommands.Count > 0)
        {
            ICommand lastExecutedCommand = _executedCommands.Pop();
            lastExecutedCommand.Undo();
        }
        else
        {
            Console.WriteLine("No command to undo.");
        }
    }
}
