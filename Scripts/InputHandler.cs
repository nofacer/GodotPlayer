using Godot;
using System;

public class InputHandler : Node
{


    public Command handleInput()
    {
        if (Input.IsActionPressed("ui_right")) { return new Command("run", "walk_right"); }
        if (Input.IsActionPressed("ui_left")) { return new Command("run", "walk_left"); }
        return null;
    }
}
