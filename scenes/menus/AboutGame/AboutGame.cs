using Godot;
using System;

public class AboutGame : Control
{


    public void _on_Start_pressed()
    {
        GetTree().ChangeScene("res://scenes/menus/MapScene.tscn");
    }

    public void _on_Back_pressed()
    {
        GetTree().ChangeScene("res://scenes/MainMenu.tscn");
    }


}
