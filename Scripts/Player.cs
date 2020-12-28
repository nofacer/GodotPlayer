using Godot;
using System;
public class Player : KinematicBody2D
{
    public Vector2 motion = new Vector2(0, 0);

    public PlayerState playerState;
    public PlayerState previousPlayerState;

    private InputHandler inputHandler = new InputHandler();

    public override void _Ready()
    {
        this.playerState = new IdleState();
    }

    public override void _PhysicsProcess(float delta)
    {
        CommandPool commands = inputHandler.handleInput();
        PlayerState newPlayerState = this.playerState.handleInput(this, commands);
        this.previousPlayerState = this.playerState;
        this.playerState = newPlayerState != null ? newPlayerState : this.playerState;
        this.playerState.enter(this);
        this.playerState.update(this, commands);
        MoveAndSlide(motion, new Vector2(0, -1));
    }

    public void playAnimation(String name)
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)this.GetNode("AnimatedSprite");
        animatedSprite.Play(name);
    }

    public void flipH()
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)this.GetNode("AnimatedSprite");
        animatedSprite.FlipH = true;
    }

    public void notFlipH()
    {
        AnimatedSprite animatedSprite = (AnimatedSprite)this.GetNode("AnimatedSprite");
        animatedSprite.FlipH = false;
    }
}
