using Godot;
using System;

public class GlassSpriteChange : Sprite
{

    private Texture[] textures;


    public override void _Ready()
    {

        textures = new Texture[] {
            (Texture)ResourceLoader.Load("res://assets/trash/Glass/GlassBottle.png"),
            (Texture)ResourceLoader.Load("res://assets/trash/Glass/GlassJar.png"),
        };


        SetRandomTexture();
    }



    private void SetRandomTexture()
    {
        var randomIndex = new Random().Next(0, textures.Length);
        Texture = textures[randomIndex];
    }
}



