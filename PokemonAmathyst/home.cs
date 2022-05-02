using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;


public class home
{
    public static (string, string, string, Rectangle) HOMER(string room, string balls, string starter, Rectangle playerRect, Rectangle TPoutside, Rectangle TPinside, Rectangle pickball, Texture2D MaleImgS, Texture2D background, Texture2D NoPoke, Texture2D Treecko, Texture2D Mudkip, Texture2D Torchic, float speed)
    {
        if (room == "home")
        {
            Raylib.BeginDrawing();

            Texture2D kitchenWall = Raylib.LoadTexture("KitchenWall.png");
            Texture2D bedroomWall = Raylib.LoadTexture("BedroomWall.png");
            Texture2D Kanna = Raylib.LoadTexture("Kanna.png");
            Texture2D Soffa = Raylib.LoadTexture("Soffa.png");
            Texture2D Table = Raylib.LoadTexture("Table.png");
            Texture2D Planta = Raylib.LoadTexture("Planta.png");
            Texture2D rdc = Raylib.LoadTexture("RDcorner.png");
            Texture2D Hflower = Raylib.LoadTexture("Hflower.png");
            Texture2D Lflower = Raylib.LoadTexture("Lflower.png");
            Texture2D Chair = Raylib.LoadTexture("Chair.png");
            Texture2D RL = Raylib.LoadTexture("RL.png");
            Texture2D CornerDL = Raylib.LoadTexture("CornerDL.png");



            Vector2 movement = MOOvement.ReadMovement(speed);



            Raylib.DrawTexture(background, 0, 0, Color.WHITE);

            Raylib.DrawTexture(MaleImgS, (int)playerRect.x, (int)playerRect.y, Color.WHITE);


            //Displays the instructions
            if (starter == "NotChosen")
            {
                Raylib.DrawText("Head to the Wardrobe and pick your first Pokemon!", 250, Raylib.GetScreenHeight() - 50, 30, Color.WHITE);
            }


            if (balls == "chosen")
            {
                Raylib.DrawText("Exit the house and catch your first Pokemon!", 300, Raylib.GetScreenHeight() - 50, 30, Color.WHITE);
            }




            if (starter == "NotChosen")
            {
                Raylib.DrawTexture(NoPoke, 550, 0, Color.WHITE);
            }

            if (starter == "Treecko")
            {
                Raylib.DrawTexture(Treecko, 550, 0, Color.WHITE);
            }

            if (starter == "Torchic")
            {
                Raylib.DrawTexture(Torchic, 550, 0, Color.WHITE);
            }

            if (starter == "Mudkip")
            {
                Raylib.DrawTexture(Mudkip, 550, 0, Color.WHITE);
            }




            //All walls that you can walk behind
            Raylib.DrawTexture(kitchenWall, 0, 384, Color.WHITE);
            Raylib.DrawTexture(bedroomWall, 775, 463, Color.WHITE);
            Raylib.DrawTexture(Kanna, 466, 386, Color.WHITE);
            Raylib.DrawTexture(Soffa, 731, 386, Color.WHITE);
            Raylib.DrawTexture(Table, 221, 687, Color.WHITE);
            Raylib.DrawTexture(Planta, 1085, 774, Color.WHITE);
            Raylib.DrawTexture(rdc, 1164, 853, Color.WHITE);
            Raylib.DrawTexture(Hflower, 778, 771, Color.WHITE);
            Raylib.DrawTexture(Lflower, 465, 778, Color.WHITE);
            Raylib.DrawTexture(Chair, 134, 676, Color.WHITE);
            Raylib.DrawTexture(RL, 1207, 507, Color.WHITE);
            Raylib.DrawTexture(CornerDL, 65, 852, Color.WHITE);


            //Borders
            List<Rectangle> walls = new List<Rectangle>();

            walls.Add(new Rectangle(0, 0, 1500, 175));
            walls.Add(new Rectangle(0, 0, 75, 1000));
            walls.Add(new Rectangle(75, 175, 77, 76));
            walls.Add(new Rectangle(152, 175, 86, 20));
            walls.Add(new Rectangle(223, 175, 143, 56));
            walls.Add(new Rectangle(464, 175, 78, 40));
            walls.Add(new Rectangle(75, 250, 35, 112));
            walls.Add(new Rectangle(75, 250, 35, 112));
            walls.Add(new Rectangle(75, 463, 310, 125));
            walls.Add(new Rectangle(464, 416, 78, 150)); //kanna
            walls.Add(new Rectangle(230, 730, 155, 72));
            walls.Add(new Rectangle(166, 730, 51, 8));
            walls.Add(new Rectangle(410, 797, 35, 5));
            walls.Add(new Rectangle(468, 820, 65, 65));
            walls.Add(new Rectangle(780, 815, 65, 65));
            walls.Add(new Rectangle(632, 265, 66, 8));
            walls.Add(new Rectangle(700, 175, 81, 138));
            walls.Add(new Rectangle(740, 435, 41, 45));
            walls.Add(new Rectangle(780, 174, 70, 453));
            walls.Add(new Rectangle(850, 535, 158, 93));
            walls.Add(new Rectangle(945, 627, 62, 21));
            walls.Add(new Rectangle(850, 175, 72, 76));
            walls.Add(new Rectangle(1011, 174, 74, 99));
            walls.Add(new Rectangle(1240, 175, 258, 825));
            walls.Add(new Rectangle(1165, 175, 75, 86));
            walls.Add(new Rectangle(1208, 348, 32, 47));
            walls.Add(new Rectangle(1208, 538, 32, 156));
            walls.Add(new Rectangle(1085, 812, 78, 73)); //Planta
            walls.Add(new Rectangle(1165, 931, 75, 68));
            walls.Add(new Rectangle(0, 931, 1500, 68));

            //Makes so that i move to the sides
            playerRect.x += movement.X;

            bool undoX = false;

            //If I walk into a wall X, checks collision
            foreach (Rectangle wall in walls)
            {
                if (Raylib.CheckCollisionRecs(playerRect, wall) == true)
                {
                    undoX = true;
                }
            }

            if (undoX) playerRect.x -= movement.X;

            //makes so that i move up and down
            playerRect.y += movement.Y;

            bool undoY = false;

            //If I walk into a wall Y, checks collision
            foreach (Rectangle wall in walls)
            {
                if (Raylib.CheckCollisionRecs(playerRect, wall) == true)
                {
                    undoY = true;
                }
            }

            if (undoY) playerRect.y -= movement.Y;

            if (Raylib.CheckCollisionRecs(playerRect, TPoutside) && balls == "chosen")
            {
                room = "outside";
                playerRect.y = 510;
                playerRect.x = 625;
            }

            if (Raylib.CheckCollisionRecs(playerRect, pickball) && (Raylib.IsKeyPressed(KeyboardKey.KEY_F)) && balls != "chosen")
            {
                balls = "choosing";
            }


            if (Raylib.CheckCollisionRecs(playerRect, pickball) && balls != "chosen")
            {
                Raylib.DrawText("Press F", 100, 100, 50, Color.WHITE);
            }

            //Adds collision to the room home
            foreach (Rectangle wall in walls)
            {
                Raylib.DrawRectangleRec(wall, Color.BLANK);
            }


            Raylib.EndDrawing();
        }

        return (room, balls, starter, playerRect);

    }
}