using Godot;
using System;

public class InputHandler : Node
{
    private WalkRightCommand walkRightCommand = new WalkRightCommand("run", "walk_right");
    private WalkLeftCommand walkLeftCommand = new WalkLeftCommand("run", "walk_left");
    public InputHandler() { }

    public Command handleInput()
    {
        if (Input.IsActionPressed("ui_right")) { return walkRightCommand; }
        if (Input.IsActionPressed("ui_left")) { return walkLeftCommand; }
        return null;
    }
}
