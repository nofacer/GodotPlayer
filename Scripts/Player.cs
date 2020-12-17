using Godot;
using System;

public class Player : KinematicBody2D
{
    private AnimatedSprite animatedSprite;

    private InputHandler inputHandler = new InputHandler();
    public override void _Ready()
    {
        this.animatedSprite = (AnimatedSprite)GetNode("AnimatedSprite");
        this.animatedSprite.Play("idle");
    }
    public override void _PhysicsProcess(float delta)
    {
        Command command = inputHandler.handleInput();
        command?.execute(this);
    }
}
