using Godot;
using System;

public class PaperPickUp : Area2D
{
    bool colliding = false;

    public void _on_Paper_body_entered(Node body)
    {
        colliding = true;
    }
    public void _on_Paper_body_exited(Node body)
    {
        colliding = false;
    }

    public override void _PhysicsProcess(float delta)
    {
        ItemSpawner itemSpawner = GetNode<ItemSpawner>("/root/GameScene/Area2D/ItemSpawner");

        TrashGameGlobal g = GetNode<TrashGameGlobal>("/root/TrashGameGlobal");

        if (g.picked)
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
        QueueFree();
        g.picked = true;
        g.paper = true;
        itemSpawner.count -= 1;
    }
}
