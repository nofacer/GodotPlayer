using Godot;
using System.Collections.Generic;


public class IdleState : PlayerState
{
    public override void enter(Player character)
    {
        character.playAnimation("idle");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        // To Run State
        if (commands.commandStringContain("run_left") || commands.commandStringContain("run_right"))
        {
            return new RunState();
        }
        // To Jump State
        if (commands.commandStringContain("jump"))
        {
            character.motion.y = -300;
            return new JumpState();
        }
        // To Fall State
        if(!character.IsOnFloor()){
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
