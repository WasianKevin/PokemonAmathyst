using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class Battle
{
    public static (string, string) Fight(string starter, string room)
    {
        Texture2D BattleTor = Raylib.LoadTexture("BattleTor.png");
        Texture2D BattleTre = Raylib.LoadTexture("BattleTre.png");
        Texture2D BattleMud = Raylib.LoadTexture("BattleMud.png");

        if (room == "battle")
        {

            Vector2 mousePos = Raylib.GetMousePosition();
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BEIGE);

            

            if (starter == "Treecko")
            {
                Raylib.DrawTexture(BattleTre, 0, 0, Color.WHITE);
            }

            if (starter == "Torchic")
            {
                Raylib.DrawTexture(BattleTor, 0, 0, Color.WHITE);
            }

            if (starter == "Mudkip")
            {
                Raylib.DrawTexture(BattleMud, 0, 0, Color.WHITE);
            }





            Raylib.EndDrawing();
        }



        return (starter, room);
    }
}
