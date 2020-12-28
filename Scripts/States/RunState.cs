using Godot;
using System.Collections.Generic;


public class RunState : PlayerState
{
    public RunState()
    {
        this.name = "run";
    }
    public override void enter(Player character)
    {
        character.playAnimation("run");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        // To Fall State, prioty 1
        if (!character.IsOnFloor())
        {
            return new FallState();
        }
        // To Idle State, prioty 2
        if (commands.isEmpty()) { return new IdleState(); }
        // To Jump State, prioty 2
        if (commands.commandStringContain("jump"))
        {
            return new JumpState();
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
