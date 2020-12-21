using Godot;
using System;

public class RunState : PlayerState
{
    public override PlayerState handleInput(Player character, Command command)
    {
        PlayerState newPlayerState = (command == null) ? new IdleState() : null;
        return newPlayerState;
    }

    public override void update(Player character, Command command)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.FlipH = (command.name == "walk_left") ? true : false;
        int flip = (command.name == "walk_left") ? -1 : 1;
        animatedSprite.Play("run");
        character.MoveAndSlide(new Vector2(flip*40, 0), new Vector2(0, -1));
    }
}
