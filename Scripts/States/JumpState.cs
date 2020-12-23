using Godot;
using System;

public class JumpState : PlayerState
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("jump");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        if (!character.IsOnFloor() && character.motion.y >= 0)
        {
            return new FallState();
        }
        return null;
    }

    public override void update(Player character, Command command)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        character.motion.y+=10;
    }
}
