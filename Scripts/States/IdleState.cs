using Godot;
using System;

public class IdleState : OnGround
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("idle");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        return base.handleInput(character, command);
    }

    public override void update(Player character, Command command)
    {
        character.motion.x = 0;
    }
}
