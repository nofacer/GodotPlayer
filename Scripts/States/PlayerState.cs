using Godot;
using System;

public class PlayerState : Node
{
    public PlayerState() { }
    public virtual PlayerState handleInput(Player character, Command command) { return null; }
    public virtual void update(Player character, Command command) { }
}
