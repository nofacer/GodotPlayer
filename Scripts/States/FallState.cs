using Godot;
using System.Collections.Generic;

public class FallState : PlayerState
{
    public FallState()
    {
        this.name = "fall";
    }
    public override void enter(Player character)
    {
        character.playAnimation("fall");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        if (character.IsOnFloor())
        {
            return new IdleState();
        }
        return null;
    }

    public override void update(Player character, CommandPool commands)
    {
        character.motion.y += 10;

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
