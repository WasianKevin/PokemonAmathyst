using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class Battle
{
    public static (string, string, string) Fight(Texture2D BattleWonTre, Rectangle tackle, string fightyboi, Texture2D BattleTreAttack, Rectangle fight, string starter, string room, Texture2D BattleTre, Texture2D BattleTor, Texture2D BattleMud)
    {

        if (room == "battle")
        {

            Vector2 mousePos = Raylib.GetMousePosition();
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BEIGE);



            if (starter == "Treecko" && fightyboi == "none")
            {
                Raylib.DrawTexture(BattleTre, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, fight) && starter == "Treecko")
            {
                fightyboi = "Treecko";
            }

            if (fightyboi == "Treecko")
            {
                Raylib.DrawTexture(BattleTreAttack, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, tackle) && fightyboi == "Treecko" && starter == "Treecko")
            {
                fightyboi = "Tackle";
            }

            if (fightyboi == "Tackle")
            {
                Raylib.DrawTexture(BattleWonTre, 0, 0, Color.WHITE);
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



        return (starter, room, fightyboi);
    }
}
