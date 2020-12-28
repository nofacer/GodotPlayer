using Godot;
using System.Collections.Generic;


public class JumpState : PlayerState
{
    public JumpState()
    {
        this.name = "jump";
    }
    public override void enter(Player character)
    {
        if (!character.previousPlayerState.GetType().Equals(typeof(JumpState)))
        {
            character.motion.y = -250;
        }
        character.playAnimation("jump");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        // To Fall State
        if (!character.IsOnFloor() && character.motion.y >= 0)
        {
            return new FallState();
        }
        // Keep Last State
        return null;
    }

    public override void update(Player character, CommandPool commands)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");

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
