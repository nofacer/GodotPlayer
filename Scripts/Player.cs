using Godot;
using System;

public class Player : KinematicBody2D
{
    private AnimatedSprite animatedSprite;
    public PlayerState playerState;

    private InputHandler inputHandler = new InputHandler();

    public override void _Ready()
    {
        this.playerState = new IdleState();
    }
    public override void _PhysicsProcess(float delta)
    {
        Command command = inputHandler.handleInput();
        PlayerState newPlayerState = this.playerState.handleInput(this, command);
        this.playerState = newPlayerState != null ? newPlayerState : this.playerState;
        this.playerState.update(this, command);
    }
}
