using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class Ballz
{
    public static (string, string) BallzDeep(string balls, string starter, Texture2D pickpoke)
    {

        while (balls == "choosing")
        {

            Rectangle Tre = new Rectangle(178, 428, 210, 210);
            Rectangle Tor = new Rectangle(554, 428, 210, 210);
            Rectangle Mud = new Rectangle(930, 428, 210, 210);

            Vector2 mousePos = Raylib.GetMousePosition();

            Raylib.BeginDrawing();

            Raylib.DrawTexture(pickpoke, 0, 0, Color.WHITE);

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, Tre))
            {
                starter = "Treecko";
                balls = "chosen";
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, Tor))
            {
                starter = "Torchic";
                balls = "chosen";
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, Mud))
            {
                starter = "Mudkip";
                balls = "chosen";
            }

            Raylib.EndDrawing();
        }

        return (starter, balls);
    }
}
