using Godot;
using System;

public class Command : Node
{
    public String group;
    public String name;
    public Command(String group, String name)
    {
        this.group = group;
        this.name = name;
    }
}
