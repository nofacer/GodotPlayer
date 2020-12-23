using System;
using Godot;

public class RunState : OnGround
{
    public override void enter(Player character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.Play("run");
    }
    public override PlayerState handleInput(Player character, Command command)
    {
        return base.handleInput(character, command);
    }

    public override void update(Player character, Command command)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.FlipH = (command.name == "walk_left") ? true : false;
        int flip = (command.name == "walk_left") ? -1 : 1;
        GD.Print(flip * Constant.PLAYER_RUN_SPEED);
        character.motion.x = flip * Constant.PLAYER_RUN_SPEED;
    }
}
