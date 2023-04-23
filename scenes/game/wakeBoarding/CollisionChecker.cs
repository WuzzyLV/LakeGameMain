using Godot;
using System;

public class CollisionChecker : Area2D
{
    public void _on_Area2D_body_entered(Node body)
    { 
        if(body.Name != "Boat" && body.Name != "WakeBoard" && body.Name != "Border_Right" && body.Name != "Border_Left")
        {

            GetTree().ChangeScene("res://scenes/game/trashing/Scenes/GameOverScreen.tscn");
        }
    }
}
