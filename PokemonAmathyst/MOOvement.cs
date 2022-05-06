using System;
using Raylib_cs;
using System.Numerics;

public class MOOvement
{
    //Creates movement. It makes so that you can only hold one key at a time. 
    //If you hold more that one key, you stand still. This makes it so that you cannot walk diagonally
    public static Vector2 ReadMovement(float speed)
    {
        Vector2 movement = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) & !Raylib.IsKeyDown(KeyboardKey.KEY_A) & !Raylib.IsKeyDown(KeyboardKey.KEY_S) & !Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) & !Raylib.IsKeyDown(KeyboardKey.KEY_D) & !Raylib.IsKeyDown(KeyboardKey.KEY_S) & !Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.X -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) & !Raylib.IsKeyDown(KeyboardKey.KEY_A) & !Raylib.IsKeyDown(KeyboardKey.KEY_D) & !Raylib.IsKeyDown(KeyboardKey.KEY_W)) movement.Y += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) & !Raylib.IsKeyDown(KeyboardKey.KEY_A) & !Raylib.IsKeyDown(KeyboardKey.KEY_S) & !Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.Y -= speed;

        return movement;
    }

}
