using System;
using System.Collections.Generic;
using Godot;
public class CommandPool
{
    private List<Command> commands = new List<Command>();
    private List<String> commandStrings = new List<String>();
    private List<String> commandGroups = new List<String>();
    public void addCommand(Command command)
    {
        if (command == null)
        {
            return;
        }
        this.commands.Add(command);
        this.commandGroups.Add(command.group);
        this.commandStrings.Add(command.name);
    }

    public List<String> getCommandStrings()
    {
        return this.commandStrings;
    }

    public List<String> getCommandGroups()
    {
        return this.commandGroups;
    }

    public void reset()
    {
        this.commands = null;
        this.commandStrings = null;
        this.commandGroups = null;
    }

    public bool commandStringContain(String name)
    {
        if (this.commandStrings.Contains(name))
        {
            return true;
        }
        return false;
    }

    public bool isEmpty()
    {
        if (this.commands == null)
        {
            return true;
        }
        if (this.commands.Count == 0)
        {
            return true;
        }
        return false;
    }
}
