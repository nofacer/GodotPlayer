using Godot;
using System.Collections.Generic;
using System;

public class IdleState : PlayerState
{
    public IdleState()
    {
        this.name = "idle";
    }
    public override void enter(Player character)
    {
        character.playAnimation("idle");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        // To Run State, prioty 1
        if (commands.commandStringContain("run_left") || commands.commandStringContain("run_right"))
        {
            return new RunState();
        }
        // To Jump State, prioty 1
        if (commands.commandStringContain("jump"))
        {
            return new JumpState();
        }
        // To Fall State, prioty 1
        if (!character.IsOnFloor())
        {
            return new FallState();
        }
        // Keep Last State
        return null;
    }

    public override void update(Player character, CommandPool commands)
    {
        character.motion.x = 0;
        character.motion.y = 0;
    }
}
