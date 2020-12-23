using Godot;
using System;
using System.Collections.Generic;
public class OnGround : PlayerState
{

    public override PlayerState handleInput(Player character, Command command)
    {
        if (character.IsOnFloor())
        {
            if (command == null)
            {
                GD.Print("idle state");
                return new IdleState();
            }
            if (command.group == "jump")
            {
                GD.Print("jump state");
                character.motion.y = -300;
                return new JumpState();
            }
            if (command.group == "run")
            {
                GD.Print("run state");
                return new RunState();
            }
        }
        else
        {
            GD.Print(character.motion.y);
            if (character.motion.y >= 0)
            {
                GD.Print("fall state");
                return new FallState();
            }
        }
        return null;
    }


    public override void update(Player character, Command command)
    {
    }
}
