using Godot;
using System;

public class Player : KinematicBody2D
{
    public Vector2 motion = new Vector2(0, 0);

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
        if (IsOnFloor())
        {
            this.motion.y = 0;
        }
        else
        {
            this.motion.y += 10;
        }
        MoveAndSlide(motion, new Vector2(0, -1));
    }
}
