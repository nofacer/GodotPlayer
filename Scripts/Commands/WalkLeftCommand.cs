using Godot;
using System;

public class WalkLeftCommand : Command
{

    public override void execute(KinematicBody2D character)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)character.GetNode("AnimatedSprite");
        animatedSprite.FlipH = true;
        character.MoveAndSlide(new Vector2(-40, 0), new Vector2(0, -1));
    }
}
