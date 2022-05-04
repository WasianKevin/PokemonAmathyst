using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class Battle
{
    public static (string, string, string) Fight(Texture2D BattleWonTre, Texture2D BattleTreAttack, Texture2D BattleWonTor, Texture2D BattleTorAttack, Texture2D BattleWonMud, Texture2D BattleMudAttack, string fightyboi, Rectangle tackle, Rectangle fight, string starter, string room, Texture2D BattleTre, Texture2D BattleTor, Texture2D BattleMud)
    {

        if (room == "battle")
        {

            Vector2 mousePos = Raylib.GetMousePosition();
            Raylib.BeginDrawing();

            Raylib.ClearBackground(Color.BEIGE);


            //Treecko battle
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
                fightyboi = "TackleTre";
            }

            if (fightyboi == "TackleTre")
            {
                Raylib.DrawTexture(BattleWonTre, 0, 0, Color.WHITE);
            }








            //Torchic battle
            if (starter == "Torchic")
            {
                Raylib.DrawTexture(BattleTor, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, fight) && starter == "Torchic")
            {
                fightyboi = "Torchic";
            }

            if (fightyboi == "Torchic")
            {
                Raylib.DrawTexture(BattleTorAttack, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, tackle) && fightyboi == "Torchic" && starter == "Torchic")
            {
                fightyboi = "TackleTor";
            }

            if (fightyboi == "TackleTor")
            {
                Raylib.DrawTexture(BattleWonTor, 0, 0, Color.WHITE);
            }










            if (starter == "Mudkip")
            {
                Raylib.DrawTexture(BattleMud, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, fight) && starter == "Mudkip")
            {
                fightyboi = "Mudkip";
            }

            if (fightyboi == "Mudkip")
            {
                Raylib.DrawTexture(BattleMudAttack, 0, 0, Color.WHITE);
            }

            if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_BUTTON_LEFT) && Raylib.CheckCollisionPointRec(mousePos, tackle) && fightyboi == "Mudkip" && starter == "Mudkip")
            {
                fightyboi = "TackleMud";
            }

            if (fightyboi == "TackleMud")
            {
                Raylib.DrawTexture(BattleWonMud, 0, 0, Color.WHITE);
            }

            Raylib.EndDrawing();
        }



        return (starter, room, fightyboi);
    }
}
