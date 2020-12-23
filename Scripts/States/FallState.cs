using Godot;
using System;

public class FallState : PlayerState
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("fall");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        if (character.IsOnFloor())
        {
            return new IdleState();
        }
        return null;
    }

    public override void update(Player character, Command command)
    {
        character.motion.y += 10;
    }
}
