using Godot;
using System.Collections.Generic;

public class InputHandler : Node
{
    public CommandPool handleInput()
    {
        CommandPool commandPool = new CommandPool();
        if (Input.IsActionPressed("ui_right"))
        {
            commandPool.addCommand(new Command("run", "run_right"));
        }
        if (Input.IsActionPressed("ui_left"))
        {
            commandPool.addCommand(new Command("run", "run_left"));
        }
        if (Input.IsActionJustPressed("ui_up")) { commandPool.addCommand(new Command("jump", "jump")); }
        return commandPool;
    }
}
