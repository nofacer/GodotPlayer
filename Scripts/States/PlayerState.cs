using Godot;
using System.Collections.Generic;

public class PlayerState : Node
{
    public PlayerState() { }
    public virtual void enter(Player character) { }
    public virtual PlayerState handleInput(Player character, CommandPool commands) { return null; }
    public virtual void update(Player character, CommandPool commands) { }
}
