using Godot;
using System;

public class MapMenuScore : Label
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Text="Punkti: "+Score.GetScore();
    }

}
