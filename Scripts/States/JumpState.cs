using Godot;
using System.Collections.Generic;


public class JumpState : PlayerState
{
    public override void enter(Player character)
    {
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
        character.motion.y += 10;
    }
}
