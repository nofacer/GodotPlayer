using Godot;
using System;

public class IdleState : PlayerState
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("idle");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        PlayerState newPlayerState = command?.group == "run" ? new RunState() : null;
        return newPlayerState;
    }

    public override void update(Player character, Command command)
    {
        character.motion.x = 0;
    }
}
