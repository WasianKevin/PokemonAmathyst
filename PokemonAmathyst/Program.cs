using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;

string room = "main";
string balls = "notchosen";
string fightyboi = "none";
string starter = "NotChosen";
float speed = 6f;

Random generator = new Random();
Raylib.InitWindow(1300, 1000, "Pokemon Amethyst");
Raylib.SetTargetFPS(30);

Texture2D background = Raylib.LoadTexture("");
Texture2D MaleImgS = Raylib.LoadTexture("MaleS.png");
Texture2D NoPoke = Raylib.LoadTexture("BarEmpty.png");
Texture2D Treecko = Raylib.LoadTexture("BarTree.png");
Texture2D Torchic = Raylib.LoadTexture("BarTor.png");
Texture2D Mudkip = Raylib.LoadTexture("BarMud.png");
Texture2D MainScreen = Raylib.LoadTexture("BannerG.png");
Texture2D Outside = Raylib.LoadTexture("OutYard.png");
Texture2D pickpoke = Raylib.LoadTexture("pickpoke.png");
Texture2D BattleTor = Raylib.LoadTexture("BattleTor.png");
Texture2D BattleTre = Raylib.LoadTexture("BattleTre.png");
Texture2D BattleMud = Raylib.LoadTexture("BattleMud.png");
Texture2D BattleTreAttack = Raylib.LoadTexture("BattleTreAttack.png");
Texture2D BattleTorAttack = Raylib.LoadTexture("BattleTorAttack.png");
Texture2D BattleMudAttack = Raylib.LoadTexture("BattleMudAttack.png");
Texture2D BattleWonTre = Raylib.LoadTexture("BattleWonTre.png");
Texture2D BattleWonTor = Raylib.LoadTexture("BattleWonTor.png");
Texture2D BattleWonMud = Raylib.LoadTexture("BattleWonMud.png");

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



//Creation of the character and obstacles
Rectangle playerRect = new Rectangle(935, 200, MaleImgS.width, MaleImgS.height);
Rectangle TPoutside = new Rectangle(543, 852, 232, 76);
Rectangle TPinside = new Rectangle(618, 418, 81, 81);
Rectangle pickball = new Rectangle(0, 284, 146, 100);
Rectangle fight = new Rectangle(647, 734, 314, 105);
Rectangle tackle = new Rectangle(102, 712, 513, 125);

(balls, background) = BallzTheFirst.BallzForreal(balls, background);

//While the window is open
while (!Raylib.WindowShouldClose())
{
    // Changing the Player Picture when turning
    (speed, MaleImgS) = Moviement.Movimint(speed, MaleImgS);

    //Main room
    (room, MainScreen) = MainRoom.RoombaMain(room, MainScreen);

    //Creation of the room "HOME"
    (room, balls, starter, playerRect) = home.HOMER(room, balls, starter, playerRect, TPoutside, TPinside, pickball, MaleImgS, background, NoPoke, Treecko, Mudkip, Torchic, speed, kitchenWall, bedroomWall, Kanna, Soffa, Table, Planta, rdc, Hflower, Lflower, Chair, RL, CornerDL);

    //Picking a starter
    (starter, balls) = Ballz.BallzDeep(balls, starter, pickpoke);

    //Outside
    (room, starter, playerRect) = OOutside.OUTSIDER(generator, room, starter, Outside, MaleImgS, TPinside, playerRect, NoPoke, Treecko, Mudkip, Torchic, speed);

    //Battle against wild Pokemon
    (starter, room, fightyboi) = Battle.Fight(BattleWonTre, BattleTreAttack, BattleWonTor, BattleTorAttack, BattleWonMud, BattleMudAttack, fightyboi, tackle, fight, starter, room, BattleTre, BattleTor, BattleMud);
}

//Movement
Vector2 movement = MOOvement.ReadMovement(speed);