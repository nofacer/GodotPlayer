using Godot;
using System.Collections.Generic;


public class RunState : PlayerState
{
    public override void enter(Player character)
    {
        character.playAnimation("run");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        // To Idle State
        if (commands.isEmpty()) { return new IdleState(); }
        // To Jump State prioty
        if (commands.commandStringContain("jump"))
        {
            return new JumpState();
        }
        // To Run State
        if (commands.commandStringContain("run_left") || commands.commandStringContain("run_right"))
        {
            return new RunState();
        }
        // Keep Last State
        return null;
    }

    public override void update(Player character, CommandPool commands)
    {
        if (commands.commandStringContain("run_left"))
        {
            character.flipH();
            character.motion.x = -1 * Constant.PLAYER_RUN_SPEED;
        }
        if (commands.commandStringContain("run_right"))
        {
            character.notFlipH();
            character.motion.x = Constant.PLAYER_RUN_SPEED;
        }
    }
}
