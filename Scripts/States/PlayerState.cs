using Godot;
using System;

public class PlayerState : Node
{
    public PlayerState() { }
    public virtual void handleInput(KinematicBody2D character) { }
    public virtual void update(KinematicBody2D character) { }
}
