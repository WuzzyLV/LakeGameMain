using Godot;
using System;

public class GlassTrashCan : Area2D
{

    bool colliding = false;
    public void _on_GlassCan_body_entered(Node body)
    {
        colliding = true;
        GD.Print("Enter glass!");
    }

    public void _on_GlassCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit! glass ");
    }

    public override void _PhysicsProcess(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        
        if (!g.glass)
        {
            return;
        }
        if (!colliding)
        {
            return;
        }
        if (!Input.IsActionJustPressed("interact"))

        {
            return;
        }
        g.picked = false;
        g.glass = false;
        g.score++;
        g.dropped = true;
    }
}
