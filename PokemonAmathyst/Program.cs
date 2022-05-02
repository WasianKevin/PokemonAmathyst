using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;

string room = "main";
string balls = "notchosen";
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

//Creation of the character and obstacles
Rectangle playerRect = new Rectangle(935, 200, MaleImgS.width, MaleImgS.height);
Rectangle TPoutside = new Rectangle(543, 852, 232, 76);
Rectangle TPinside = new Rectangle(618, 418, 81, 81);
Rectangle pickball = new Rectangle(0, 284, 146, 100);

(balls, background) = BallzTheFirst.BallzForreal(balls, background);

//While the window is open
while (!Raylib.WindowShouldClose())
{
    // Changing the Player Picture when turning
    (speed, MaleImgS) = Moviement.Movimint(speed, MaleImgS);

    //Main room
    (room, MainScreen) = MainRoom.RoombaMain(room, MainScreen);

    //Creation of the room "HOME"
    (room, balls, starter, playerRect) = home.HOMER(room, balls, starter, playerRect, TPoutside, TPinside, pickball, MaleImgS, background, NoPoke, Treecko, Mudkip, Torchic, speed);

    //Outside
    (room, starter, playerRect) = OOutside.OUTSIDER(generator, room, starter, Outside, MaleImgS, TPinside, playerRect, NoPoke, Treecko, Mudkip, Torchic, speed);

    //Battle against wild Pokemon
    (starter, room) = Battle.Fight(starter, room);
}

//Movement
Vector2 movement = MOOvement.ReadMovement(speed);