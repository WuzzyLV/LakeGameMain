using Godot;
using System;

public class Timer : RichTextLabel
{

    private float timeElapsed = 90f;
    private int minutes;
    private int seconds;
    private int milliseconds;
    private string timeString;

    public override void _Process(float delta)
    {
        timeElapsed -= delta;
        minutes = Mathf.FloorToInt(timeElapsed / 60);
        seconds = Mathf.FloorToInt(timeElapsed % 60);
        milliseconds = Mathf.FloorToInt((timeElapsed % 1) * 100);
        timeString = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
        Text = timeString;
       
       
        if (timeElapsed <= 0)
        {
            GetTree().ChangeScene("res://Scenes/GameOverScreen.tscn");
           
        }
    }
            
    
}

