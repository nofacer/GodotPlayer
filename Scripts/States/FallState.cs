using Godot;
using System;

public class FallState : OnGround
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("fall");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        return base.handleInput(character, command);
    }

    public override void update(Player character, Command command)
    {
        character.motion.y += 10;
    }
}
