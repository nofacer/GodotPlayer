using Godot;
using System;

public class InputHandler : Node
{
    private WalkRightCommand walkRightCommand = new WalkRightCommand();
    private WalkLeftCommand walkLeftCommand = new WalkLeftCommand();
    public InputHandler() { }

    public Command handleInput()
    {
        if (Input.IsActionPressed("ui_right")) { return walkRightCommand; }
        if (Input.IsActionPressed("ui_left")) { return walkLeftCommand; }
        return null;
    }
}
