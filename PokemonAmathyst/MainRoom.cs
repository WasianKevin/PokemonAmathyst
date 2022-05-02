using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class MainRoom
{
    public static (string, Texture2D) RoombaMain(string room, Texture2D MainScreen)
    {

    if (room == "main")
    {
        Raylib.BeginDrawing();

        Raylib.DrawTexture(MainScreen, 0, 0, Color.WHITE);

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
        {
            room = "home";
        }

        Raylib.EndDrawing();
    }

        return (room, MainScreen);
    }
}
