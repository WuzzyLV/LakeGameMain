using Godot;
using System;

public class PaperTrashCan : Area2D
{
    bool colliding = false;
    public void _on_PaperCan_body_entered(Node body)
    {
        colliding = true;
        GD.Print("Enter paper!");
    }

    public void _on_PaperCan_body_exited(Node body)
    {
        colliding = false;
        GD.Print("Exit! paper ");
    }

    public override void _PhysicsProcess(float delta)
    {
        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");
        if (!g.picked)
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
        if (Input.IsActionJustPressed("interact") && !g.paper && g.picked)
        {
            g.dropped = true;
            g.picked = false;
            g.score--;
            g.plastic = false; g.glass = false;
            return;
        }
        g.picked = false;
        g.paper = false;
        g.score++;
        g.dropped = true;
    }
}
