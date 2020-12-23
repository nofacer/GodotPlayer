using Godot;
using System.Collections.Generic;

public class FallState : PlayerState
{
    public override void enter(Player character)
    {
        character.playAnimation("fall");
    }
    public override PlayerState handleInput(Player character, CommandPool commands)
    {
        if (character.IsOnFloor())
        {
            return new IdleState();
        }
        return null;
    }

    public override void update(Player character, CommandPool commands)
    {
        character.motion.y += 10;
    }
}
