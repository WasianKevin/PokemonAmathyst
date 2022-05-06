using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class MainRoom
{
    public static (string, Texture2D) RoombaMain(string room, Texture2D MainScreen)
    {

        //Creation of main room AKA main menu
        if (room == "main")
        {
            //Allows me to draw a room
            Raylib.BeginDrawing();

            //Draws the background
            Raylib.DrawTexture(MainScreen, 0, 0, Color.WHITE);

            //I switch room if i press ENTER
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
            {
                room = "home";
            }

            Raylib.EndDrawing();
        }

        return (room, MainScreen);
    }
}
