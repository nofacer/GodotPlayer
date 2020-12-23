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
        if (command?.group == "run")
        {
            return new RunState();
        }
        if (command?.group == "jump")
        {
            character.motion.y = -300;
            return new JumpState();
        }
        return null;
    }

    public override void update(Player character, Command command)
    {
        character.motion.x = 0;
    }
}
