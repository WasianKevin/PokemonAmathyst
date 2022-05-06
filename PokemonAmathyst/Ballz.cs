using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class Ballz
{
    public static (string, string) BallzDeep(string balls, string starter, Texture2D pickpoke)
    {
        //What happens when choosing a pokemon starter
        while (balls == "choosing")
        {
            //Drawing up the rectangles used in the picking menu
            Rectangle Tre = new Rectangle(178, 428, 210, 210);
            Rectangle Tor = new Rectangle(554, 428, 210, 210);
            Rectangle Mud = new Rectangle(930, 428, 210, 210);

            //Allows the user to use his mouse
            Vector2 mousePos = Raylib.GetMousePosition();

            //draws the room
            Raylib.BeginDrawing();

            //Background
            Raylib.DrawTexture(pickpoke, 0, 0, Color.WHITE);

            //Allows me to pick Treecko as my starter
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, Tre))
            {
                starter = "Treecko";
                balls = "chosen";
            }

            //Allows me to pick Torchic as my starter
            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, Tor))
            {
                starter = "Torchic";
                balls = "chosen";
            }

            //Allows me to pick Mudkip as my starter
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
