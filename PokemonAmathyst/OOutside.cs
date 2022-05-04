using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;


public class OOutside
{
    public static (string, string, Rectangle) OUTSIDER(Random generator, string room, string starter, Texture2D Outside, Texture2D MaleImgS, Rectangle TPinside, Rectangle playerRect, Texture2D NoPoke, Texture2D Treecko, Texture2D Mudkip, Texture2D Torchic, float speed)
    {
        if (room == "outside")
        {
            Raylib.BeginDrawing();


            //Movement
            Vector2 movement = MOOvement.ReadMovement(speed);

            Raylib.DrawTexture(Outside, 0, 0, Color.WHITE);

            Raylib.DrawTexture(MaleImgS, (int)playerRect.x, (int)playerRect.y, Color.WHITE);

            //Borders
            List<Rectangle> Walls = new List<Rectangle>();
            Walls.Add(new Rectangle(0, 0, 1316, 145));
            Walls.Add(new Rectangle(0, 0, 156, 1000));
            Walls.Add(new Rectangle(0, 893, 1316, 108));
            Walls.Add(new Rectangle(1160, 0, 159, 1000));
            Walls.Add(new Rectangle(430, 0, 458, 486));


            //Makes so that i move to the sides
            playerRect.x += movement.X;

            bool undoX = false;

            //If I walk into a wall X, checks collision
            foreach (Rectangle wall in Walls)
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
            foreach (Rectangle wall in Walls)
            {
                if (Raylib.CheckCollisionRecs(playerRect, wall) == true)
                {
                    undoY = true;
                }
            }




            //Grass + catchrate
            List<Rectangle> Grass = new List<Rectangle>();
            Grass.Add(new Rectangle(0, 0, 339, 999));
            Grass.Add(new Rectangle(339, 545, 132, 455));
            Grass.Add(new Rectangle(471, 731, 366, 270));
            Grass.Add(new Rectangle(838, 545, 132, 455));
            Grass.Add(new Rectangle(970, 0, 347, 999));



            //If I walk into a wall X, checks collision
            foreach (Rectangle wall in Grass)
            {
                if (Raylib.CheckCollisionRecs(playerRect, wall) == true)
                {
                    int EncounterRate = generator.Next(100);

                    if (EncounterRate == 1)
                    {
                        room = "battle";
                    }

                }
            }


            if (Raylib.CheckCollisionRecs(playerRect, TPinside))
            {
                room = "home";
                playerRect.y = 740;
                playerRect.x = 625;
            }

            if (undoY) playerRect.y -= movement.Y;



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




            Raylib.EndDrawing();
        }

        return (room, starter, playerRect);

    }
}
