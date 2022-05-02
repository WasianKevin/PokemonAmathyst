using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;
using System.Threading;
public class BallzTheFirst
{
    public static (string, Texture2D) BallzForreal(string balls, Texture2D background)
    {

        if (balls == "chosen")
        {
            background = Raylib.LoadTexture("Home.png");
        }

        if (balls == "notchosen")
        {
            background = Raylib.LoadTexture("HomeP.png");
        }

        return (balls, background);
    }
}