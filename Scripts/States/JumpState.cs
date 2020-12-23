using Godot;
using System;

public class JumpState : OnGround
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("jump");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        return base.handleInput(character, command);
    }

    public override void update(Player character, Command command)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        character.motion.y+=10;
    }
}
